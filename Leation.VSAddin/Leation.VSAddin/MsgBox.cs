using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Leation.VSAddin
{
    /// <summary>
    /// �ṩͳһ����MessageBox�Ի���
    /// </summary>
    internal static class MsgBox
    {
        private static readonly string Caption = "����ΰ��VS��չ���";

        /// <summary>
        /// ��ʾ������Ϣ
        /// </summary>
        /// <param name="msg">������Ϣ</param>
        public static void ShowTip(string msg)
        {
            MessageBox.Show(msg, Caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// ��ʾOkCancel�Ի���
        /// </summary>
        /// <param name="msg">��ʾ��Ϣ</param>
        public static DialogResult ShowOkCancel(string msg)
        {
            return MessageBox.Show(msg, Caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

    }
}
