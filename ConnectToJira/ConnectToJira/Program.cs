using System;
using System.IO;
using System.Net;
using Atlassian;
using Atlassian.Jira;

// https://jira.atlassian.com/rest/api/latest/issue/JRA-9
// https://trello.com/b/ycVwgBcY/intern-2022.atlassian.net/rest/api/2/field
// https://adam-mcneil.atlassian.net/jira/software/c/projects/TEST/issues/?filter=allissues

namespace ConnectToJira
{
    class Program
    {
        static void Main(string[] args)
        {
            Jira jiraConnection = new Jira("https://adam-mcneil.atlassian.net.com", "adamwmcneil@gmail.com", "something");

           /* // Create a request for the URL. 		
            WebRequest request = WebRequest.Create("https://trello.com/b/ycVwgBcY/intern-2022.atlassian.net/rest/api/2/field");
            // If required by the server, set the credentials.
            request.Credentials = CredentialCache.DefaultCredentials;
            // Get the response.
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            // Display the status.
            Console.WriteLine(response.StatusDescription);
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Display the content.
            Console.WriteLine(responseFromServer);
            // Cleanup the streams and the response.
            reader.Close();
            dataStream.Close();
            response.Close();*/
        }
    }
}
