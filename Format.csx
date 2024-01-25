foreach(var m in Selected.Measures) {
    var newMeasure = m.Table.AddMeasure(
    m.Name + "_FORMAT",                                          // Name
    "FORMAT ("           
    + m.DaxObjectName + ","
    + " \"  ⮝0.0%  ;  ⮟-0.0%  \", \"pt-BR\") ",                // DAX expression
        m.DisplayFolder                                        // Display Folder
    );
    newMeasure.FormatString = "0.00";
    newMeasure.Description = "Formatação da " + m.DaxObjectFullName;
}