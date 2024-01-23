var dateColumn = "dCalendario[Data]";                   // Precisa mudar a coluna de data
foreach(var m in Selected.Measures) {
    var newMeasure = m.Table.AddMeasure(
    m.Name + "_LY",                                             // Name
    "CALCULATE ("           
    + m.DaxObjectName + ","
    + "SAMEPERIODLASTYEAR(" + dateColumn + "))",                         // DAX expression
        m.DisplayFolder                                        // Display Folder
    );
    newMeasure.FormatString = "0.00";
    newMeasure.Description = "Ano anterior da " + m.DaxObjectFullName;
}