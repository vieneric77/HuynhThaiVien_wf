using System;

namespace BT_WinForm
{
    public class Faculty
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }

        // Constructor mặc định
        public Faculty()
        {
        }

        // Constructor 1 tham số (nếu chỉ cần tên)
        public Faculty(string name)
        {
            Name = name;
        }

        // Constructor đầy đủ (khuyến nghị)
        public Faculty(string id, string name, int quantity)
        {
            Id = id;
            Name = name;
            Quantity = quantity;
        }

        // Hiển thị trên ComboBox (nếu không dùng DisplayMember)
        public override string ToString()
        {
            return Name;
        }
    }
}
