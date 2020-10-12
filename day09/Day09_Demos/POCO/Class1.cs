using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyOwnAttributes;
namespace POCO
{
	[Table(TableName ="Employee")]
    public class Emp
    {
		private int _No;
		private string _Name;

		[Column(ColumnName ="EName", ColumnType ="varchar(50)")]
		public string Name
		{
			get { return _Name; }
			set { _Name = value; }
		}

		[Column(ColumnName = "ENo", ColumnType = "int")]
		public int No
		{
			get { return _No; }
			set { _No = value; }
		}

	}

	[Table(TableName = "Book")]
	public class Book
	{
		private int _ISBN;

		[Column(ColumnName ="ISBN", ColumnType = "int")]
		public int ISBN
		{
			get { return _ISBN; }
			set { _ISBN = value; }
		}

		private string _Title;

		[Column(ColumnName = "Title", ColumnType = "varchar(50)")]
		public string Title
		{
			get { return _Title; }
			set { _Title = value; }
		}

		private string _Author;

		[Column(ColumnName = "Autho", ColumnType = "varchar(50)")]
		public string Author
		{
			get { return _Author; }
			set { _Author = value; }
		}



	}
}
