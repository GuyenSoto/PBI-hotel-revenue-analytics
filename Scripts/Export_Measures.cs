var measures = Model.AllMeasures;
var script = "";
foreach(var m in measures)
{
    script += m.DaxObjectFullName + " = " + m.Expression + "\r\n\r\n";
}
SaveFile(@"D:\path\ExportMeasures.txt", script);