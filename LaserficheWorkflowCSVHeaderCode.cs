//Remember when creating and using this script in your Workflow to add this outside of your for each
//This is made to run once, creating headers to which your data appends to in a logical format
namespace WorkflowActivity.Scripting.OnceOffHeaders
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Text;
    using System.IO; //Remember to add this when writing anything to a file.

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
            string text = "YourHeader1"+","+"YourHeader2"+","+"YourHeader3"+"\r\n";

            File.AppendAllText("C:\\Your\\Path\\Here\\YourCSVDocumentName.csv", text);
        }
    }
}