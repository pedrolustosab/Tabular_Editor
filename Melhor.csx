var Column = "dProduto[PRODUTO]"; // Precisa mudar a coluna de data

foreach(var m in Selected.Measures) {
    var newMeasure = m.Table.AddMeasure(
    m.Name + "_" + Column + "_Best", // Name
        "CONCATENATEX(" +
        "TOPN(1, ALLSELECTED(" + Column + "), " + m.DaxObjectName + ")," +
            Column +
            ", \", \")", // DAX expression
        m.DisplayFolder // Display Folder
    );

    newMeasure.FormatString = "0.00";
    newMeasure.Description = "O melhor da " + m.DaxObjectFullName;
}
