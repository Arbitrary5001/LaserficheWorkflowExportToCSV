# LaserficheWorkflowExportToCSV
This code allows you to easily export any data, whether it be a single line or an array of information into a CSV file, 
which can be emailed or further manipulated.
//
This project is ideal for exporting data directly from SQL/Laserfiche Forms Process/search results in yourLaserfiche Repository 
into a CSV file.
(There are, in some cases, better alternatives. I have found having this in your Workflow Designer and understanding how it works can defintely be helpful). 
A great example of this would be if you had a drop-down field in the Repository that allows the end-user to select "Export Contents" or something similar. Which will then kick of a Workflow that knows which data to export, relevant to the process.
I'm personally using this for reports which data I only have in SQL and are displaying to the end-user in a small Laserfiche Forms process. They would ideally either submit the form or I'd have a scheduled Workflow export the data, email it to them and delete the file at the end.
//
Please let me know if there are any suggestions or thoughts, I am new to C#/Jquery and are exploring other languages and ideas regarding integration and automation, both in and outside the Laserfiche environment.
