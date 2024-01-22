foreach(var m in Selected.Measures) {
    var newMeasure = m.Table.AddMeasure(
    m.Name + "_KPI",                                             // Name
    m.DaxObjectName,                                            // DAX expression
    m.DisplayFolder                                            // Display Folder
    );
    newMeasure.FormatString = "0.00";
    newMeasure.Description = "Criar a KPI da medida: " + m.DaxObjectFullName;
}