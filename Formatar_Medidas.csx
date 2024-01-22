var _sMeasures = Selected.Measures;      //Switch <<Selected.Measures>> to << Model.AllMeasures>> to format ALL DAX measures in the Model
var _useShortFormatDAX = true;          //Switch to <<true>> for using Short Format DAX for selected measures
var _insertLineBreakOnFirstLine = false; //Switch to <<true>> for adding a break line between Measure Name and DAX Formula
var _addDAXToDescription = true;        //Switch to <<true>> for adding the DAX Expression as a Description of the Measure
var _SpaceAfterFunctionName = true;     //Switch to <<true>> to insert a space after DAX function Name
foreach (var m in Model.AllMeasures) 
{
    m.FormatDax();
    CallDaxFormatter(shortFormat : _useShortFormatDAX, skipSpaceAfterFunctionName: !_SpaceAfterFunctionName);

}