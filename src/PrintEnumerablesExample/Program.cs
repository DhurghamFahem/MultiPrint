﻿using MultiPrint.Documents;
using MultiPrint.Settings;
using PrintEnumerablesExample;
using QuestPDF.Fluent;
using QuestPDF.Previewer;

var accounts = InvoiceDocumentDataSource.GetAccounts();

var settings = new MultiPrintPageSettings
{
    Header = new HeaderSettings
    {
        Value = "علاوي الغالي"
    }
};

var accountsDocument = new EnumerableDocument<AccountModel>(accounts, settings);
accountsDocument.ShowInPreviewer();