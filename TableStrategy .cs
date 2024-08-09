using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Splus_Extras
{
    internal class TableStrategy: IContentStrategy
    {
        public List<Range> GetContent(Document doc)
        {
            List<Range> tableTexts = new List<Range>();
            if (doc == null)
                return new List<Range>();

            return doc.Tables.Cast<Table>()
                .SelectMany(table => GetTableContent(table))
                .ToList();
        }

        private IEnumerable<Range> GetTableContent(Table table)
        {
            return table.Rows.Cast<Row>()
                .SelectMany(row => row.Cells.Cast<Cell>()
                    .Select(cell => cell.Range)
                    .Where(range => !string.IsNullOrWhiteSpace(range.Text)));
        }
    }
}
