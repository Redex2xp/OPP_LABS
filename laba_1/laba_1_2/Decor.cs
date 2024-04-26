using System.Text;

namespace laba_1_2
{
    internal class Decor : INowDateTimeFormatter
    {
        private INowDateTimeFormatter _output;

        public Decor(INowDateTimeFormatter pole)
        {
            this._output = pole;
        }

        public string FormataDateTime()
        {
            var sb = new StringBuilder();
            sb.Append("Now ");
            sb.Append(_output.FormataDateTime());
            return sb.ToString();
        }
    }
}