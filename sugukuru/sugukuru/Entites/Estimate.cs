using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sugukuru.Entites
{
    public class Estimate
    {
        // 受注番号
        private String orderNumber;

        // 品名
        private String productName;

        // 数量
        private String quantity;

        // 単位
        private String unit;

        // 単価
        private String unitPrice;

        // 合計金額
        private String totalPrice;

        public string OrderNumber { get => orderNumber; set => orderNumber = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string Quantity { get => quantity; set => quantity = value; }
        public string Unit { get => unit; set => unit = value; }
        public string UnitPrice { get => unitPrice; set => unitPrice = value; }
        public string TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}
