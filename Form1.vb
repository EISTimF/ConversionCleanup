Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cleanedUp As String

        cleanedUp = txt_orig.Text
        ' testing
        cleanedUp = cleanedUp.Replace(".ToString ", ".ToString() ")
        cleanedUp = cleanedUp.Replace(".ToString,", ".ToString(),")
        cleanedUp = cleanedUp.Replace(".ToString)", ".ToString())")
        cleanedUp = cleanedUp.Replace(".ToString;", ".ToString();")
        cleanedUp = cleanedUp.Replace(".Tables(p_x)", ".Tables[p_x]")
        cleanedUp = cleanedUp.Replace(".Tables(p_y)", ".Tables[p_y]")
        cleanedUp = cleanedUp.Replace(".Tables(p_z)", ".Tables[p_z]")
        cleanedUp = cleanedUp.Replace(".Rows(p_x)", ".Rows[p_x]")
        cleanedUp = cleanedUp.Replace(".Rows(p_y)", ".Rows[p_y]")
        cleanedUp = cleanedUp.Replace(".Rows(p_z)", ".Rows[p_z]")
        cleanedUp = cleanedUp.Replace(".Item(p_x)", ".Item[p_x]")
        cleanedUp = cleanedUp.Replace(".Item(p_y)", ".Item[p_y]")
        cleanedUp = cleanedUp.Replace(".Item(p_z)", ".Item[p_z]")
        cleanedUp = cleanedUp.Replace(""" + """, Environment.NewLine)
        cleanedUp = cleanedUp.Replace("return_parsed_single_quote_string", "ReturnParsedSingleQuoteString")
        cleanedUp = cleanedUp.Replace("dba_format_unique_identifier_value", "FormatUID")
        cleanedUp = cleanedUp.Replace("g_framework.Execute_Query(p_sql)", "ExecuteQuery(p_sql, EisGlobals.EisGeneral.DbName)")
        cleanedUp = cleanedUp.Replace("g_framework.Get_Data(p_sql)", "GetData(p_sql, EisGlobals.EisGeneral.DbName)")
        cleanedUp = cleanedUp.Replace("Execute_Query(p_sql)", "ExecuteQuery(p_sql, EisGlobals.EisGeneral.DbName)")
        cleanedUp = cleanedUp.Replace("Get_Data(p_sql)", "GetData(p_sql, EisGlobals.EisGeneral.DbName)")
        cleanedUp = cleanedUp.Replace("g_framework.Execute_Query(sql)", "ExecuteQuery(sql, EisGlobals.EisGeneral.DbName)")
        cleanedUp = cleanedUp.Replace("g_framework.Get_Data(sql)", "GetData(sql, EisGlobals.EisGeneral.DbName)")
        cleanedUp = cleanedUp.Replace("Execute_Query(sql)", "ExecuteQuery(sql, EisGlobals.EisGeneral.DbName)")
        cleanedUp = cleanedUp.Replace("Get_Data(sql)", "GetData(sql, EisGlobals.EisGeneral.DbName)")
        cleanedUp = cleanedUp.Replace("g_framework.Execute_Query", "ExecuteQuery")
        cleanedUp = cleanedUp.Replace("g_framework.Get_Data", "GetData")
        cleanedUp = cleanedUp.Replace("Execute_Query", "ExecuteQuery")
        cleanedUp = cleanedUp.Replace("Get_Data", "GetData")
        cleanedUp = cleanedUp.Replace("CenterMsgBox", "MessageBox")
        cleanedUp = cleanedUp.Replace("MsgBoxStyle.Information", "MessageBoxButtons.OK, MessageBoxIcon.Information")
        cleanedUp = cleanedUp.Replace("MsgBoxStyle.Critical", "MessageBoxButtons.OK, MessageBoxIcon.Error")
        cleanedUp = cleanedUp.Replace("MsgBoxStyle.YesNo", "MessageBoxButtons.YesNo, MessageBoxIcon.Question")
        cleanedUp = cleanedUp.Replace("Constants.vbNo", "DialogResult.No")
        cleanedUp = cleanedUp.Replace("Constants.vbYes", "DialogResult.Yes")
        cleanedUp = cleanedUp.Replace(" | ", " || ")
        cleanedUp = cleanedUp.Replace(" & ", " && ")
        cleanedUp = cleanedUp.Replace("g_user_info.user_id", "Application.Session.EisUserID")
        cleanedUp = cleanedUp.Replace("string p_sql = """"", "StringBuilder sb = new StringBuilder()")
        cleanedUp = cleanedUp.Replace("string p_sql", "StringBuilder sb = new StringBuilder()")
        cleanedUp = cleanedUp.Replace("p_sql = ", "sb.Append(")
        cleanedUp = cleanedUp.Replace("p_sql &= ", "sb.Append(")
        cleanedUp = cleanedUp.Replace("p_sql += ", "sb.Append(")
        cleanedUp = cleanedUp.Replace("return p_sql;", "return sb.ToString();")
        cleanedUp = cleanedUp.Replace("p_sql,", "sb.ToString(),")
        cleanedUp = cleanedUp.Replace("string sql = """"", "StringBuilder sb = new StringBuilder()")
        cleanedUp = cleanedUp.Replace("string sql", "StringBuilder sb = new StringBuilder()")
        cleanedUp = cleanedUp.Replace("sql = ", "sb.Append(")
        cleanedUp = cleanedUp.Replace("sql &= ", "sb.Append(")
        cleanedUp = cleanedUp.Replace("sql += ", "sb.Append(")
        cleanedUp = cleanedUp.Replace("return sql;", "return sb.ToString();")
        cleanedUp = cleanedUp.Replace("dba_user_tbl", "eis_group_tbl")
        cleanedUp = cleanedUp.Replace("dba_id", "eis_group_id")
        cleanedUp = cleanedUp.Replace("DateAndTime", "DateTime")
        cleanedUp = cleanedUp.Replace("Constants.VbCrLf", """\n""")
        cleanedUp = cleanedUp.Replace("sender.cancel = True", "TLB_main.CancelEvent = true;")
        cleanedUp = cleanedUp.Replace(".TextBox_Properties", "")
        cleanedUp = cleanedUp.Replace(".DateBox_Properties", "")

        For x As Integer = 0 To 99
            cleanedUp = cleanedUp.Replace($".Tables({x})", $".Tables[{x}]")
            cleanedUp = cleanedUp.Replace($".Rows({x})", $".Rows[{x}]")
            cleanedUp = cleanedUp.Replace($".Item({x})", $"[{x}]")
            cleanedUp = cleanedUp.Replace($"({x})", $"[{x}]")
        Next

        txt_cleaned.Text = cleanedUp
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Clipboard.SetText(txt_cleaned.Text)
    End Sub
End Class
