//This code can be used to delete any file locally within the specified directory on your server
//Ensure your Workflow has access rights to the directory
namespace WorkflowActivity.Scripting.DeleteOnceOffCSV
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Text;
    using System.IO;

    /// <summary>
    /// Provides one or more methods that can be run when the workflow scripting activity is performed.
    /// </summary>
    public class Script1 : ScriptClass90
    {
        /// <summary>
        /// This method is run when the activity is performed.
        /// </summary>
        protected override void Execute()
        {
            string destinationFile = @"C:\\Your\\Directory\\Here\\YourDocumentName.csv";

                try
                    {
                     File.Delete(destinationFile);
                    }
                    catch (IOException iox)
                    {
                    Console.WriteLine(iox.Message);
                    }
        }
    }
}
