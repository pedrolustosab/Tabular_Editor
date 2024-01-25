var dateColumn = "dProduto[PRODUTO]"; // Precisa mudar a coluna de data

foreach(var m in Selected.Measures) {
    var newMeasure = m.Table.AddMeasure(
        m.Name + "_Best", // Name
        "CONCATENATEX(" +
        "TOPN(1, ALLSELECTED(" + dateColumn + "), " + m.DaxObjectName + ")," +
            dateColumn +
            ", \", \")", // DAX expression
        m.DisplayFolder // Display Folder
    );

    newMeasure.FormatString = "0.00";
    newMeasure.Description = "O melhor da " + m.DaxObjectFullName;
}
