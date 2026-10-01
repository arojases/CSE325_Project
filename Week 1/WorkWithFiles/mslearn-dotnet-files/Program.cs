using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;

var currentDirectory = Directory.GetCurrentDirectory();
var storesDirectory = Path.Combine(currentDirectory, "stores");
var salesFiles = FindFiles(storesDirectory);

var salesTotalDir = Path.Combine(currentDirectory, "salesTotalDir");
Directory.CreateDirectory(salesTotalDir);   // Add this line of code

var salesTotal = CalculateSalesTotal(salesFiles); // Add this line of code

File.AppendAllText(Path.Combine(salesTotalDir, "totals.txt"), $"{salesTotal}{Environment.NewLine}");

//Generate the final report
GenerateReport(salesFiles, salesTotalDir, salesTotal);

IEnumerable<string> FindFiles(string folderName)
{
    List<string> salesFiles = new List<string>();

    var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

    foreach (var file in foundFiles)
    {
        var extension = Path.GetExtension(file);
        // The file name will contain the full path, so only check the end of it
        if (extension == ".json")
        {
            salesFiles.Add(file);
        }
    }

    return salesFiles;
}

double CalculateSalesTotal(IEnumerable<string> salesFiles)
{
    double salesTotal = 0;

    // Loop over each file path in salesFiles
    foreach (var file in salesFiles)
    {
        // Read the contents of the file
        string salesJson = File.ReadAllText(file);

        // Parse the contents as JSON
        SalesData? data = JsonConvert.DeserializeObject<SalesData?>(salesJson);

        // Add the amount found in the Total field to the salesTotal variable
        salesTotal += data?.Total ?? 0;
    }

    return salesTotal;
}

void GenerateReport(IEnumerable<string> salesFiles, string salesTotalDir, double salesTotal)
{
    //creates StringBuilder to buuild the report line by line
    StringBuilder report = new StringBuilder();

    report.AppendLine("Sales Summary Report");
    report.AppendLine("====================");
    report.AppendLine("");

    report.AppendLine($"Total Sales: {salesTotal:C}");
    report.AppendLine("");

    report.AppendLine("Details:");

    //loop each sales files found
    foreach (var file in salesFiles)
    {
        // Read the contents of the current JSON file
        string salesJson = File.ReadAllText(file);

        //get only the folder and the file name
        var folder = Path.GetFileName(Path.GetDirectoryName(file));
        var filename = Path.GetFileName(file);

        //chheck the file if is salestotal.json // I did this because I didnt know if we supouse to take both files or just the sales.json
        if (filename == "salestotals.json")
        {
            SalesData? data =
                JsonConvert.DeserializeObject<SalesData?>(salesJson);

            double fileOverallTotal = data?.OverallTotal ?? 0;

            report.AppendLine(
                $"{folder}/{filename}: - Overall Total: {fileOverallTotal:C}"
            );
        }
        else
        {
            SalesData? data =
                JsonConvert.DeserializeObject<SalesData?>(salesJson);

            double fileTotal = data?.Total ?? 0;

            report.AppendLine(
                $"{folder}/{filename}: - Total: {fileTotal:C}"
            );
        }
    }

    //creates the full path for the report file
    var reportFilePath = Path.Combine(salesTotalDir, "SalesReport.txt");
    //Write the report to the file
    File.WriteAllText(reportFilePath, report.ToString());

}

record SalesData(double Total, double OverallTotal);
