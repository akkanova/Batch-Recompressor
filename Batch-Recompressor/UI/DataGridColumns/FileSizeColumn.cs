using Batch_Recompressor.Common;
using System.ComponentModel;

namespace Batch_Recompressor.UI.DataGridColumns
{
    public class FileSizeColumn : DataGridViewTextBoxColumn
    {
        private static readonly DataGridViewCellStyle s_defaultStyle;

        static FileSizeColumn()
        {
            s_defaultStyle = new()
            {
                Alignment = DataGridViewContentAlignment.MiddleRight,
                Padding = new Padding(0, 0, 2, 0)
            };
        }

        public FileSizeColumn()
        {
            CellTemplate = new FileSizeCell();
            DefaultCellStyle = s_defaultStyle;
        }
    }

    public class FileSizeCell : DataGridViewTextBoxCell
    {
        public FileSizeCell()
        {
            base.ValueType = typeof(ulong);
        }

        protected override object GetFormattedValue(
            object value, 
            int rowIndex, 
            ref DataGridViewCellStyle cellStyle, 
            TypeConverter valueTypeConverter, 
            TypeConverter formattedValueTypeConverter, 
            DataGridViewDataErrorContexts context) 
        {
            if (value is ulong fileSize)
                return fileSize != 0 
                    ? Misc.FileSizeToString(fileSize) 
                    : string.Empty;

            return base.GetFormattedValue(value, rowIndex, ref cellStyle, valueTypeConverter, formattedValueTypeConverter, context);
        }
    }
}
