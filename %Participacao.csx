var Medida = "[#PRECO]"; // Precisa mudar a coluna 
foreach(var c in Selected.Columns)
{
    var newMeasure = c.Table.AddMeasure(
        "%P_" + c.Name + "_" + Medida,                     
        "FORMAT(DIVIDE(" + Medida + ", CALCULATE(" + Medida + ", ALLSELECTED(" + c.DaxObjectFullName + "))), \"0.0%\", \"pt-br\")",    
        c.DisplayFolder                        
    );
  
    newMeasure.FormatString = "0.0%";
    newMeasure.Description = "Prercetual de contribuição da " + c.DaxObjectFullName;
    c.IsHidden = false;
}