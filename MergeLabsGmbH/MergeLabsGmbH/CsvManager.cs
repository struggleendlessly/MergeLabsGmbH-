﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeLabsGmbH
{
    public class CsvManager
    {
        private const char CsvNewLineCharacter = '\n';
        private const char CsvCellSeperator = ',';
        private const string CsvNullCellIdentifier = "NULL";

        public static string SimpleTransformCsv(string S)
        {
            var res = string.Empty;

            if (S == null)
            {
                throw new ArgumentNullException();
            }

            StringBuilder sb = new StringBuilder();
            string[] rows = S.Split(CsvNewLineCharacter);
            sb.Append(rows[0]); // preserve header row
            sb.Append(CsvNewLineCharacter);

            for (int i = 1; i < rows.Length; i++)
            {
                bool nullFound = false;
                string[] cells = rows[i].Split(CsvCellSeperator);
                foreach (string cell in cells)
                {
                    if (cell.Trim().Equals(CsvNullCellIdentifier))
                    {
                        nullFound = true;
                        break;
                    }
                }

                if (!nullFound)
                {
                    sb.Append(rows[i]);
                    sb.Append(CsvNewLineCharacter);
                }
            }

            res = sb.ToString();

            return res;
        }
    }
}
