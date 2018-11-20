﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン: 15.0.0.0
//  
//     このファイルへの変更は、正しくない動作の原因になる可能性があり、
//     コードが再生成されると失われます。
// </auto-generated>
// ------------------------------------------------------------------------------
namespace sugukuru
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\takaa\C#\src\ih31_team6\sugukuru\sugukuru\DocumentHtmlTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class DocumentHtmlTemplate : DocumentHtmlTemplateBase
    {
        // 書類の種別     "請求"||"見積"
        private string documentType;

        // 書類作成日     "20181116"
        private string documentCreationDate;

        // 書類作成者     "山田"
        private string documentCreationReq;

        // 書類番号       "1234567..."
        private string documentNumber;

        // 書類有効期限   "見積後２週間"
        private string expirationDate;

        // 顧客名         "株式会社oo"
        private string clientName;

        // 顧客郵便番号   "000-0000"
        private string clientZip;

        // 顧客住所1      "東京都千代田区千代田１−１"
        private string clientAddress1;

        // 顧客住所2      "ビル名など"
        private string clientAddress2;

        // 顧客FAX        "00-1111-2222"
        private string clientFAX;

        // 顧客TEL        "00-1111-3333"
        private string clientTEL;

        // 顧客部署       "総務"
        private string clientDivision;

        // 顧客担当者     "山田 太郎"
        private string clientReq;

        // 支払い条件     "20日締めの当月15日払い"
        private string clientPaymentTerms;

        // 納期           "別途相談"
        private string clientDeliveryDate;

        // 備考           "なし"
        private string remarks;

        private List<Entites.Estimate> quoteList;

        public string DocumentType { get => documentType; set => documentType = value; }
        public string DocumentCreationDate { get => documentCreationDate; set => documentCreationDate = value; }
        public string DocumentCreationReq { get => documentCreationReq; set => documentCreationReq = value; }
        public string DocumentNumber { get => documentNumber; set => documentNumber = value; }
        public string ExpirationDate { get => expirationDate; set => expirationDate = value; }
        public string ClientName { get => clientName; set => clientName = value; }
        public string ClientZip { get => clientZip; set => clientZip = value; }
        public string ClientAddress1 { get => clientAddress1; set => clientAddress1 = value; }
        public string ClientAddress2 { get => clientAddress2; set => clientAddress2 = value; }
        public string ClientFAX { get => clientFAX; set => clientFAX = value; }
        public string ClientTEL { get => clientTEL; set => clientTEL = value; }
        public string ClientDivision { get => clientDivision; set => clientDivision = value; }
        public string ClientReq { get => clientReq; set => clientReq = value; }
        public string ClientPaymentTerms { get => clientPaymentTerms; set => clientPaymentTerms = value; }
        public string ClientDeliveryDate { get => clientDeliveryDate; set => clientDeliveryDate = value; }
        public string Remarks { get => remarks; set => remarks = value; }
        public List<Entites.Estimate> QuoteList { get => quoteList; set => quoteList = value; }

        // List<Entites.Estimate>の中身をjsに最適化する。
        private string detailsText(List<Entites.Estimate> _QuoteList)
        {
            StringBuilder detail = new StringBuilder("");
            for (int i = 0; i < _QuoteList.Count; i++)
            {
                detail.Append("{");
                detail.AppendFormat("\"品名\":\"{0}\",\"数量\":{1},\"単位\":\"台\",\"単価\":{2}", _QuoteList[i].ProductName, _QuoteList[i].Quantity, _QuoteList[i].UnitPrice);
                detail.Append("},");
            }
            return detail.ToString();
        }
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            string detail = detailsText(quoteList);

            this.Write("<!DOCTYPE html>\r\n<html lang=\"ja\">\r\n  <head>\r\n    <script type=\"text/javascript\">\r" +
                    "\n      // このフィールドを変えるだけで書類が完成します。\r\n      var data = {\r\n        \"種別\":\""+this.documentType+"\",\r\n     " +
                    "   \"作成日\":\""+this.documentCreationDate+"\",\r\n        \"番号\":\""+this.documentNumber+"\",\r\n        \"有効期限\":\""+this.expirationDate+"\",\r\n      " +
                    "  \"宛先\":{\r\n          \"名称\":\""+this.clientName+"\",\r\n          \"郵便番号\":\""+this.clientZip+"\",\r\n          " +
                    "\"住所1\":\""+this.clientAddress1+"\",\r\n          \"住所2\":\"\",\r\n          \"TEL\":\""+this.clientTEL+"\",\r\n          \"FAX\":\""+this.clientFAX+"\",\r\n          \"部署\":\""+this.clientDivision+"\",\r\n          \"担当者" +
                    "\":\""+this.clientReq+"\",\r\n          \"支払条件\":\""+this.clientPaymentTerms+"\",\r\n          \"納期\":\""+this.clientDeliveryDate+"\",\r\n        }" +
                    ",\r\n        \"自社\":{\r\n          \"名称\":\"スグクル車販株式会社\",\r\n          \"郵便番号\":\"534-0011\",\r\n " +
                    "         \"住所1\":\"大阪府都島区高倉町1丁目4-6\",\r\n          \"住所2\":\"エンブレム都島408号\",\r\n          \"TE" +
                    "L\":\"(03)1234-5678\",\r\n          \"FAX\":\"(03)1234-5678\",\r\n          \"部署\":\"事務員\",\r\n     " +
                    "     \"担当者\":\""+this.documentCreationReq+"\"\r\n        },\r\n        \"明細\":[\r\n          "+detail+"\r\n        ],\r\n        \"備考\":\""+this.remarks+"\"\r\n      };\r\n\r\n    </script>\r\n  " +
                    "  \r\n    <meta charset=\"UTF-8\">\r\n    <script src=\"http://ajax.googleapis.com/ajax" +
                    "/libs/jquery/1.10.2/jquery.min.js\"></script>\r\n    <link rel=\"stylesheet\" href=\"h" +
                    "ttp://netdna.bootstrapcdn.com/bootstrap/3.0.0/css/bootstrap.min.css\">\r\n  </head>" +
                    "\r\n  <body>\r\n    <div class=\"container\">\r\n      <h1 style=\"text-align:center;\"><s" +
                    "pan class=\"category\">請求|見積</span>書</h1>\r\n      <div class=\"row\">\r\n\r\n        <!--" +
                    " 宛先情報をhtmlにセットします。 -->\r\n        <div class=\"col-md-7 col-xs-7\">\r\n          <h2 i" +
                    "d=\"to-name\">株式会社 xx 御中</h2>\r\n          〒<span id=\"to-zip\">XXX-XXXXX</span><br/>\r" +
                    "\n          <span id=\"to-address1\">東京都XX区XXXX1-2-3</span><br/>\r\n          <span i" +
                    "d=\"to-address2\">XXビル1F</span>\r\n          TEL:　<span id=\"to-tel\">03-1234-567" +
                    "8</span><br/>\r\n          FAX:　<span id=\"to-fax\">00-0000-0000</span><br/>\r\n      " +
                    "    担当部署:　<span id=\"to-division\">○○</span><br/>\r\n          担当者:　<span id=\"to-di" +
                    "visionrep\">○○ ××</span>　様<br/><br>\r\n          支払条件:　<span id=\"to-payment-terms\">" +
                    "xxxxxxxxxx</span>　<br/>\r\n          納期:　<span id=\"to-delivery-date\">xxxxxxxxxx</s" +
                    "pan>　<br/>\r\n          有効期限: <span id=\"expiration-date\">xxxxxxxxxx</span>　<br/>\r\n" +
                    "        </div>\r\n\r\n        <!-- 自社情報をhtmlにセットします。 -->\r\n        <div class=\"col-md" +
                    "-5 col-xs-5\" style=\"text-align:right;\">\r\n          <big><span id=\"date\">0000年00月" +
                    "00日</span></big><br/>\r\n          <span class=\"category\">請求|見積</span>番号:　<span id" +
                    "=\"code\">YYYYMMDD-XX</span>\r\n          <h2 id=\"from-name\">株式会社 xx </h2>\r\n        " +
                    "  〒<span id=\"from-zip\">XXX-XXXXX</span><br/>\r\n          <span id=\"from-address1\"" +
                    ">東京都XX区XXXX1-2-3</span><br/>\r\n          <span id=\"from-address2\">XXビル1F</span><b" +
                    "r/>\r\n          TEL:　<span id=\"from-tel\">03-1234-5678</span><br/>\r\n          FAX:" +
                    "　<span id=\"from-fax\">00-0000-0000</span><br/>\r\n          担当者:　<span id=\"from-div" +
                    "isionrep\">・宦・××</span> <br/>\r\n        </div>\r\n\r\n      </div>\r\n\r\n      <div style" +
                    "=\"margin-top:2em;\"></div>\r\n      <div class=\"row\">\r\n        <div class=\"col-md-8" +
                    " col-xs-8\">\r\n          <big>下記のとおり御<span class=\"category\">請求|見積</span>申し上げます。</b" +
                    "ig>\r\n        </div>\r\n        <div class=\"col-md-4 col-xs-4\" style=\"text-align:ri" +
                    "ght;\">\r\n          単位: 円\r\n        </div>\r\n      </div>\r\n\r\n      <table class=\"tab" +
                    "le\">\r\n        <thead>\r\n          <tr>\r\n            <th style=\"width:4em;text-ali" +
                    "gn:right;\">項番</th><th>品名</th><th style=\"width:4em;text-align:right;\">数量</th><th " +
                    "style=\"width:4em;\">単位</th><th style=\"text-align:right;\">単価</th><th style=\"text-a" +
                    "lign:right;\">金額</th>\r\n          </tr>\r\n        </thead>\r\n        <tbody>\r\n      " +
                    "    <tr class=\"row-template\">\r\n            <td class=\"num\" style=\"text-align:rig" +
                    "ht;\">N</td><td class=\"name\">PRODUCT NAME</td><td class=\"qty\" style=\"text-align:r" +
                    "ight;\">NN</td><td class=\"unit\">人日</td><td class=\"unit-price\" style=\"text-align:r" +
                    "ight;\">XX,000</td><td class=\"price\" style=\"text-align:right;\">XX,000</td>\r\n     " +
                    "     </tr>\r\n          <tr>\r\n            <td colspan=\"3\" rowspan=\"3\">\r\n          " +
                    "    <div class=\"bank\">\r\n                <h4>振込先</h4>\r\n                三井住友銀行 粉浜支" +
                    "店 普通 1234567 ｽｸﾞｸﾙｼﾔﾊﾝ(ｶ\r\n              </div>\r\n              <h4>備考</h4><span i" +
                    "d=\"remarks\">xxxx</span></td>\r\n              <td colspan=\"2\">小計</td>\r\n           " +
                    "   <td class=\"minor-total\" style=\"text-align:right;\">XX,000</td>\r\n          </tr" +
                    ">\r\n          <tr>\r\n            <td colspan=\"2\">消費税(<span class=\"tax-rate\">8</spa" +
                    "n>%)</td><td class=\"vat\" style=\"text-align:right;\">XX,000</td>\r\n          </tr>\r" +
                    "\n          <tr>\r\n            <td colspan=\"2\">合計</td><td style=\"text-align:right;" +
                    "\"><big><strong><span class=\"grand-total\">XX,000</span></strong></big></td>\r\n    " +
                    "      </tr>\r\n        </tbody>\r\n      </table>\r\n    </div>\r\n    <script type=\"tex" +
                    "t/javascript\">\r\n      function addFigure(value) {\r\n        var num = new String(" +
                    "value).replace(/,/g, \"\");\r\n        while(num != (num = num.replace(/^(-?\\d+)(\\d{" +
                    "3})/, \"$1,$2\")));\r\n        return num;\r\n      }\r\n\r\n      $(document).ready(funct" +
                    "ion() {\r\n        if (data[\"種別\"] != \"請求\") { $(\".bank\").hide() ; }\r\n\r\n        $(\"<" +
                    "title>\" +　data[\"種別\"] + data[\"番号\"] + \"</title>\").prependTo(\"head\");\r\n\r\n        va" +
                    "r year = parseInt(data[\"作成日\"].substr(0,4));\r\n        var month = parseInt(data[\"" +
                    "作成日\"].substr(4,2));\r\n        var day = parseInt(data[\"作成日\"].substr(6,2));\r\n\r\n   " +
                    "     // 書類種別をidへセットします。\r\n        $(\"span.category\").text(data[\"種別\"]);\r\n\r\n       " +
                    " // 作成日をidへセットします。\r\n        $(\"#date\").text(\"日付:　\"+year+\"年\"+month+\"月\"+day+\"日\");\r" +
                    "\n\r\n        // 書類番号をidへセットします。\r\n        $(\"#code\").text(data[\"番号\"]);\r\n\r\n        /" +
                    "/ 有効期限をidへセットします。\r\n        $(\"#expiration-date\").text(data[\"有効期限\"]);\r\n\r\n        " +
                    "// 宛先情報をidへセットします。\r\n        $(\"#to-name\").text(data[\"宛先\"][\"名称\"]);\r\n        $(\"#t" +
                    "o-zip\").text(data[\"宛先\"][\"郵便番号\"]);\r\n        $(\"#to-address1\").text(data[\"宛先\"][\"住所" +
                    "1\"]);\r\n        $(\"#to-address2\").text(data[\"宛先\"][\"住所2\"]);\r\n        $(\"#to-tel\")." +
                    "text(data[\"宛先\"][\"TEL\"]);\r\n        $(\"#to-fax\").text(data[\"宛先\"][\"FAX\"]);\r\n       " +
                    " $(\"#to-division\").text(data[\"宛先\"][\"部署\"]);\r\n        $(\"#to-divisionrep\").text(da" +
                    "ta[\"宛先\"][\"担当者\"]);\r\n        $(\"#to-payment-terms\").text(data[\"宛先\"][\"支払条件\"]);\r\n   " +
                    "     $(\"#to-delivery-date\").text(data[\"宛先\"][\"納期\"]);\r\n\r\n        // 自社情報をidへセットします" +
                    "。\r\n        $(\"#from-name\").text(data[\"自社\"][\"名称\"]);\r\n        $(\"#from-zip\").text(" +
                    "data[\"自社\"][\"郵便番号\"]);\r\n        $(\"#from-address1\").text(data[\"自社\"][\"住所1\"]);\r\n    " +
                    "    $(\"#from-address2\").text(data[\"自社\"][\"住所2\"]);\r\n        $(\"#from-tel\").text(da" +
                    "ta[\"自社\"][\"TEL\"]);\r\n        $(\"#from-fax\").text(data[\"自社\"][\"FAX\"]);\r\n        $(\"#" +
                    "from-division\").text(data[\"自社\"][\"部署\"]);\r\n        $(\"#from-divisionrep\").text(dat" +
                    "a[\"自社\"][\"担当者\"]);\r\n\r\n        // 備考をidへセットします。\r\n        $(\"#remarks\").text(data[\"備" +
                    "考\"]);\r\n\r\n        // 明細情報のレイアウトを整え　小計・消費税・合計金額を自動で計算し、idへセットします。\r\n        var row" +
                    "s = Array();\r\n        var total = 0;\r\n        $.each(data[\"明細\"], function(i, val" +
                    "ue) {\r\n          var row = $(\"tr.row-template\").clone(false);\r\n          row.fin" +
                    "d(\"td.num\").text(\"\" + (i + 1));\r\n          row.find(\"td.name\").text(value[\"品名\"])" +
                    ";\r\n          row.find(\"td.qty\").text(value[\"数量\"]);\r\n          row.find(\"td.unit\"" +
                    ").text(value[\"単位\"]);\r\n          row.find(\"td.unit-price\").text(addFigure(value[\"" +
                    "単価\"]));\r\n          var price = ~~(value[\"数量\"] * value[\"単価\"]);\r\n          row.fin" +
                    "d(\"td.price\").text(addFigure(price));\r\n          total += price;\r\n          rows" +
                    ".push(row);\r\n        });\r\n        $(\"tr.row-template\").remove();\r\n        $(\"tbo" +
                    "dy\").prepend(rows);\r\n        $(\"td.minor-total\").text(addFigure(total));\r\n      " +
                    "  var vat = ~~(total * 8 / 100);\r\n        $(\"td.vat\").text(addFigure(vat));\r\n   " +
                    "     $(\"span.grand-total\").text(addFigure(total + vat));\r\n      });\r\n    </scrip" +
                    "t>\r\n  </body>\r\n</html>\r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public class DocumentHtmlTemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
