using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace dotnetnewmvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DeviceListener();
            CreateHostBuilder(args).Build().Run();
        }

        public static async void DeviceListener()
        {
            TcpListener server = new TcpListener(new IPAddress(new byte[] { 0, 0, 0, 0 }), 8000);
            server.Start();
            while(true)
            {
                TcpClient client = await server.AcceptTcpClientAsync();
                RunWorker(client);
                //Debug.WriteLine(((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString());
            }
        }

        public static async void RunWorker(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            ushort i, k;
            ushort checksum;
            byte[] bytes = new byte[515];
            await stream.ReadAsync(bytes, 0, 2);
            /*   Device is 1 and command to execute is 0 => Scenario when Raspberry PI send a carplate number to be checked in the database   */
            if(bytes[0] == 1 && bytes[1] == 0)
            {                
                i = 2;
                await stream.ReadAsync(bytes, i, 1);
                while(bytes[i] != 0)
                {
                    Debug.Write(Encoding.ASCII.GetString(bytes, i, 1));
                    i++;
                    await stream.ReadAsync(bytes, i, 1);
                }
                i++;
                await stream.ReadAsync(bytes, i, 2);
                checksum = 0;
                for(k = 0; k < i-1; k++)
                {
                    checksum += bytes[k];
                }
                if(checksum == ((((ushort)(bytes[i])) << 8) | bytes[i+1]))
                {
                    /* To do: Check database for received number (bytes[0->i-2]) => Send 0 for access and 1 otherwise */
                    await stream.WriteAsync(new byte[] { 0 });
                    //await stream.WriteAsync(new byte[] { 1 });

                }
                else
                {       
                        /*   Data lost occured => Sending command   */
                        await stream.WriteAsync(new byte[] { 2 });
                }
            }
            /*   Device is 2 and command to execute is 0 => Scenario when Smartphone asks for the current datetime from Cloud   */
            else if (bytes[0] == 2 && bytes[1] == 0)
            {
                byte[] date = new byte[16];
                date[0] = (byte)DateTime.Now.Year.ToString()[0];
                date[1] = (byte)DateTime.Now.Year.ToString()[1];
                date[2] = (byte)DateTime.Now.Year.ToString()[2];
                date[3] = (byte)DateTime.Now.Year.ToString()[3];

                if (DateTime.Now.Month.ToString().Length == 1)
                {
                    date[4] = 48;
                    date[5] = (byte)DateTime.Now.Month.ToString()[0];

                }
                else
                {
                    date[4] = (byte)DateTime.Now.Month.ToString()[0];
                    date[5] = (byte)DateTime.Now.Month.ToString()[1];

                }

                if (DateTime.Now.Day.ToString().Length == 1)
                {
                    date[6] = 48;
                    date[7] = (byte)DateTime.Now.Day.ToString()[0];

                }
                else
                {
                    date[6] = (byte)DateTime.Now.Day.ToString()[0];
                    date[7] = (byte)DateTime.Now.Day.ToString()[1];
                }

                if (DateTime.Now.Hour.ToString().Length == 1)
                {
                    date[8] = 48;
                    date[9] = (byte)DateTime.Now.Hour.ToString()[0];

                }
                else
                {
                    date[8] = (byte)DateTime.Now.Hour.ToString()[0];
                    date[9] = (byte)DateTime.Now.Hour.ToString()[1];
                }

                if (DateTime.Now.Minute.ToString().Length == 1)
                {
                    date[10] = 48;
                    date[11] = (byte)DateTime.Now.Minute.ToString()[0];

                }
                else
                {
                    date[10] = (byte)DateTime.Now.Minute.ToString()[0];
                    date[11] = (byte)DateTime.Now.Minute.ToString()[1];
                }

                if (DateTime.Now.Second.ToString().Length == 1)
                {
                    date[12] = 48;
                    date[13] = (byte)DateTime.Now.Second.ToString()[0];

                }
                else
                {
                    date[12] = (byte)DateTime.Now.Second.ToString()[0];
                    date[13] = (byte)DateTime.Now.Second.ToString()[1];

                }

                checksum = 0;

                for (i = 0; i < 14; i++)
                    checksum += date[i];

                //Debug.WriteLine(checksum.ToString());

                date[14] = (byte)(checksum >> 8);
                date[15] = (byte)(checksum & 0x00FF);
                await stream.WriteAsync(date);


            }
            /*   Device is 3 and command to execute is 0 => Scenario when Laptop sends the CNP and datetime extracted from the QR code   */
            else if (bytes[0] == 3 && bytes[1] == 0)
            {
                await stream.ReadAsync(bytes, 2, 29);
                checksum = 0;
                for (i = 0; i < 29; i++)
                    checksum += bytes[i];
                if(checksum == (ushort)(bytes[29] << 8 | bytes[30]))
                {
                        string cnp_datetime = Encoding.ASCII.GetString(bytes, 2, 27);
                        DateTime datetime = DateTime.ParseExact(cnp_datetime.Substring(13), "yyyyMMddHHmmss", System.Globalization.CultureInfo.InvariantCulture);
                        if ((DateTime.Now - datetime).TotalMinutes >= 5)
                        {
                            await stream.WriteAsync(new byte[] { 1 });
                        }
                        else
                        {
                            await stream.WriteAsync(new byte[] { 0 });
                            /* To do: Extract CNP and check if it is found in the database */
                        }
                }
                else
                {
                    /*   Data lost occured => Sending command to repeat transmission   */
                    await stream.WriteAsync(new byte[] { 2 });
                }

            }
            /*   Device is 2 and command to execute is 1 => Scenario when Smartphone sends an email and an password to be verified in the database   */
            else if (bytes[0] == 2 && bytes[1] == 1)
            {
                i = 2;
                await stream.ReadAsync(bytes, i, 1);
                while(bytes[i] != '\0')
                {
                    i++;
                    await stream.ReadAsync(bytes, i, 1);
                }
                i++;
                await stream.ReadAsync(bytes, i, 2);
                checksum = 0;
                for (k = 0; k < i - 1; k++)
                    checksum += bytes[k];
                if(checksum == (ushort)((bytes[i] << 8) | (bytes[i+1])))
                {
                    /* To do: Verify email and password received to match database  */
                    string email_password = Encoding.ASCII.GetString(bytes, 2, i - 1);
                    await stream.WriteAsync(new byte[] { 1 });
                }
                else
                {
                    /*   Data lost occured => Sending command to repeat transmission  */
                    await stream.WriteAsync(new byte[] { 2 });
                }
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}