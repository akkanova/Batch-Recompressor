using Batch_Recompressor.AllPurpose;
using Batch_Recompressor.Core;
using System.ComponentModel;

namespace Batch_Recompressor.UI
{
    public class ProgressBarColumn : DataGridViewColumn
    {
        public ProgressBarColumn()
        {
            CellTemplate = new ProgressBarCell();
        }
    }

    public class ProgressBarCell : DataGridViewImageCell
    {
        public static Color ProgressBarColor { get; }
        public static Image EmptyImage { get; }

        static ProgressBarCell()
        {
            EmptyImage = new Bitmap(1, 1, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            ProgressBarColor = Color.FromArgb(56, 230, 84);
        }

        public ProgressBarCell()
        {
            base.ValueType = typeof(Core.TaskStatus);
        }

        protected override object GetFormattedValue(
            object value, 
            int rowIndex, 
            ref DataGridViewCellStyle cellStyle, 
            TypeConverter valueTypeConverter, 
            TypeConverter formattedValueTypeConverter, 
            DataGridViewDataErrorContexts context)
        {
            return EmptyImage;
        }

        protected override void Paint(
            Graphics graphics, 
            Rectangle clipBounds, 
            Rectangle cellBounds, 
            int rowIndex, 
            DataGridViewElementStates elementState, 
            object value, 
            object formattedValue, 
            string errorText, 
            DataGridViewCellStyle cellStyle, 
            DataGridViewAdvancedBorderStyle advancedBorderStyle, 
            DataGridViewPaintParts paintParts)
        {
            base.Paint(graphics, clipBounds, cellBounds, 
                rowIndex, elementState, value, 
                formattedValue, errorText, cellStyle, 
                advancedBorderStyle, paintParts);

            if (value is null) 
                return;

            // Draw Simple Background Progress Bar
            Core.TaskStatus status = (Core.TaskStatus) value;
            if (status.Progress > 0)
                graphics.FillRectangle(
                    new SolidBrush(ProgressBarColor),
                    cellBounds.X + 2, // Include 2px of padding
                    cellBounds.Y + 2,
                    (int)(status.Progress / 100.0 * cellBounds.Width - 4),
                    cellBounds.Height - 4
                );

            // Draw Text (Middle Center)
            string text = status.State != TaskState.Ongoing
                ? Misc.ToSentenceCase(status.State.ToString())
                : status.Progress.ToString();

            Size textSize = TextRenderer.MeasureText(text, cellStyle.Font);
            float textPosX = cellBounds.X + (cellBounds.Width / 2) - textSize.Width / 2;
            float textPosY = cellBounds.Y + (cellBounds.Height / 2) - textSize.Height / 2;

            graphics.DrawString(
                text, cellStyle.Font,
                new SolidBrush(cellStyle.ForeColor),
                textPosX, textPosY);
        }
    }
}
