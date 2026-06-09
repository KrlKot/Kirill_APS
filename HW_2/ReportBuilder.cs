using System;
using System.Security.Cryptography;
using System.Text;

public class ReportBuilder
{
	private DatabaseManager _db;
	private string _sql;
	private string _title;
	private string[] _columns;
	private int[] _widths;
	public ReportBuilder(DatabaseManager db)
	{
		_db = db;
	}
	public ReportBuilder Query(string sql) { _sql = sql; return this; }
    public ReportBuilder Title(string title) { _title = title; return this; }
    public ReportBuilder Header(params string[] columns) { _columns = columns; return this; }
	public ReportBuilder ColumnWidths(params int[] widths) {  _widths = widths; return this; }
	public string Build() 
	{
		var (columns, rows) = _db.ExecuteQuery(_sql);
		var builder = new StringBuilder();
		builder.Append($"=== {_title} ===\n");

		for (int i = 0; i < columns.Length; i++) { builder.Append(columns[i].PadRight(_widths[i])); builder.Append("|"); }
		builder.Append("\n");
		builder.Append('-', _widths.Sum() + 2 + _widths.Length / 3);
        builder.Append("\n");
		foreach (var row in rows)
		{
			for (int i = 0; i < row.Length; i++) { builder.Append(row[i].PadRight(_widths[i])); builder.Append("|"); }
			builder.Append("\n");
		}
		return builder.ToString();
	}
	public void Print() 
	{
		Console.WriteLine(Build());
	}
}
