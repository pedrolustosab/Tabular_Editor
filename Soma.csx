foreach(var c in Selected.Columns)
{
    var newMeasure = c.Table.AddMeasure(
    "#" + c.Name,                    
        "SUM(" + c.DaxObjectFullName + ")",    
        c.DisplayFolder                        
    );
  
    newMeasure.FormatString = "0.00";
    newMeasure.Description = "Soma da coluna " + c.DaxObjectFullName;
    c.IsHidden = false;
}