foreach(var c in Selected.Columns)
{
    var newMeasure = c.Table.AddMeasure(
        "*" + c.Name,                    
        "DISTINCTCOUNT(" + c.DaxObjectFullName + ")",    
        c.DisplayFolder                        
    );
  
    newMeasure.FormatString = "0";
    newMeasure.Description = "Contagem da coluna " + c.DaxObjectFullName;
    c.IsHidden = false;
}