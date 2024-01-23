var dateColumn = "'Demandas'[Data de Entrada]";                   // Precisa mudar a coluna de data
foreach(var m in Selected.Measures) {
    var newMeasure = m.Table.AddMeasure(
    m.Name + "_Best",                                             // Name
    "CONCATENATEX(TOPN(1, VALUES(" + Column + ")," + m.DaxObjectName + ")," + Column +",\", \")"                        // DAX expression
        m.DisplayFolder                                        // Display Folder
    );
    newMeasure.FormatString = "0.00";
    newMeasure.Description = "O melhor da " + m.DaxObjectFullName;
}