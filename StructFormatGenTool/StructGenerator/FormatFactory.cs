﻿using Generator.Format;
using StructGenerator;
using StructGenerator.Format;

namespace Generator
{
    public class FormatFactory
    {
        public IFile Create(OutFormat.Type format, object file)
        {
            if(format == OutFormat.Type.STRUCT_FILE)
            {
                var excelfile = file as ExcelFile;
                return new StructFile(excelfile);
            }

            if (format == OutFormat.Type.SQL_TABLE_FILE)
            {
                var excelfile = file as ExcelFile;
                return new SQLTableFile(excelfile);
            }

            if (format == OutFormat.Type.DB_POCO_CLASS_FILE)
            {
                var excelfile = file as FileInfo;
                return new DBPoCoClassFile(excelfile);
            }

            return null;
        }

    }
}
