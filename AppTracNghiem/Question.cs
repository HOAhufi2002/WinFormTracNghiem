using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTracNghiem
{
    public class Question
    {
        public int MaCauHoi { get; set; }      // Mã câu hỏi
        public string NoiDung { get; set; }    // Nội dung câu hỏi
        public string LuaChonA { get; set; }   // Lựa chọn A
        public string LuaChonB { get; set; }   // Lựa chọn B
        public string LuaChonC { get; set; }   // Lựa chọn C
        public string LuaChonD { get; set; }   // Lựa chọn D
        public char DapAnDung { get; set; }    // Đáp án đúng (A, B, C, D)
        public char UserAnswer { get; set; }   // Câu trả lời của người dùng
    }
}
