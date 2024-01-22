foreach(var m in Selected.Measures) {
    var newMeasure = m.Table.AddMeasure(
    m.Name + "_CLT",                                             // Name
    "SWITCH (TRUE ()," + m.DaxObjectName + " > 0, \"#369B43\"," + m.DaxObjectName + " < 0, \"#C80919\", \"#7E898D\")",                        // DAX expression
    m.DisplayFolder                                        // Display Folder
    );
    newMeasure.Description = "Cor da " + m.DaxObjectFullName;
}
