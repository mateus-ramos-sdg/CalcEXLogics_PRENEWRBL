// Decompiled with JetBrains decompiler
// Type: CalcExtendedLogics.CalcEXlogicClass
// Assembly: CalcEXLogics, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B156438D-AED8-483E-90C5-D2A68D115AC8
// Assembly location: C:\Users\ramosm\Desktop\Calcex_dll_recompiled\CalcEXLogics_PRENEWRBL.dll

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

#nullable disable
namespace CalcExtendedLogics
{
  public class CalcEXlogicClass
  {
    public static bool Execute(DataSet _DataSet, string _CalcArgument, string _TargetDataTableName)
    {
      bool flag;
      try
      {
        switch (_CalcArgument)
        {
          case "central_initial_allocation_fixed":
            CalcEXlogicClass.central_initial_allocation_fixed(_DataSet, _TargetDataTableName);
            break;
          case "central_push_fixed":
            CalcEXlogicClass.central_push_fixed(_DataSet, _TargetDataTableName);
            break;
          case "central_push_gdo":
            CalcEXlogicClass.central_push_gdo(_DataSet, _TargetDataTableName);
            break;
          case "central_push_woh":
            CalcEXlogicClass.central_push_woh(_DataSet, _TargetDataTableName);
            break;
          case "central_rblres_fixed_priority":
            CalcEXlogicClass.central_rblres_fixed_priority(_DataSet, _TargetDataTableName);
            break;
          case "central_rblres_gdo":
            CalcEXlogicClass.central_rblres_gdo(_DataSet, _TargetDataTableName);
            break;
          case "central_rblres_stockout":
            CalcEXlogicClass.central_rblres_stockout(_DataSet, _TargetDataTableName);
            break;
          case "central_rblres_wohsubs":
            CalcEXlogicClass.central_rblres_wohsubs(_DataSet, _TargetDataTableName);
            break;
          case "central_rpl_fixed_buying_reserve":
            CalcEXlogicClass.central_rpl_fixed_buying_reserve(_DataSet, _TargetDataTableName);
            break;
          case "central_rpl_gdo_buying_reserve":
            CalcEXlogicClass.central_rpl_gdo_buying_reserve(_DataSet, _TargetDataTableName);
            break;
          case "central_rpl_stockout_buying_reserve":
            CalcEXlogicClass.central_rpl_stockout_buying_reserve(_DataSet, _TargetDataTableName);
            break;
          case "central_rpl_woh_buying_reserve":
            CalcEXlogicClass.central_rpl_woh_buying_reserve(_DataSet, _TargetDataTableName);
            break;
          case "central_rpl_wohsub_buying_reserve":
            CalcEXlogicClass.central_rpl_wohsub_buying_reserve(_DataSet, _TargetDataTableName);
            break;
          case "regional_initial_allocation_fixed":
            CalcEXlogicClass.regional_initial_allocation_fixed(_DataSet, _TargetDataTableName);
            break;
          case "regional_initial_allocation_gdo":
            CalcEXlogicClass.regional_initial_allocation_gdo(_DataSet, _TargetDataTableName);
            break;
          case "regional_push_fixed":
            CalcEXlogicClass.regional_push_fixed(_DataSet, _TargetDataTableName);
            break;
          case "regional_push_gdo":
            CalcEXlogicClass.regional_push_gdo(_DataSet, _TargetDataTableName);
            break;
          case "regional_push_woh":
            CalcEXlogicClass.regional_push_woh(_DataSet, _TargetDataTableName);
            break;
          case "regional_rebalance_gdo":
            CalcEXlogicClass.regional_rebalance_gdo(_DataSet, _TargetDataTableName);
            break;
          case "regional_rebalance_gdo_new_opening":
            CalcEXlogicClass.regional_rebalance_gdo_new_opening(_DataSet, _TargetDataTableName);
            break;
          case "regional_rebalance_gdo_woh":
            CalcEXlogicClass.regional_rebalance_gdo_woh(_DataSet, _TargetDataTableName);
            break;
          case "regional_rebalance_oh":
            CalcEXlogicClass.regional_rebalance_oh(_DataSet, _TargetDataTableName);
            break;
          case "regional_rebalance_woh":
            CalcEXlogicClass.regional_rebalance_woh(_DataSet, _TargetDataTableName);
            break;
          case "regional_rpl_fixed_buying_reserve":
            CalcEXlogicClass.regional_rpl_fixed_buying_reserve(_DataSet, _TargetDataTableName);
            break;
          case "regional_rpl_gdo_buying_reserve":
            CalcEXlogicClass.regional_rpl_gdo_buying_reserve(_DataSet, _TargetDataTableName);
            break;
          case "regional_rpl_gdowoh_buying_reserve":
            CalcEXlogicClass.regional_rpl_gdowoh_buying_reserve(_DataSet, _TargetDataTableName);
            break;
          case "regional_rpl_stockout_buying_reserve":
            CalcEXlogicClass.regional_rpl_stockout_buying_reserve(_DataSet, _TargetDataTableName);
            break;
          case "regional_rpl_woh_buying_reserve":
            CalcEXlogicClass.regional_rpl_woh_buying_reserve(_DataSet, _TargetDataTableName);
            break;
          case "regional_rpl_wohsub_buying_reserve":
            CalcEXlogicClass.regional_rpl_wohsub_buying_reserve(_DataSet, _TargetDataTableName);
            break;
          case "reserve_rebalance_gdo":
            CalcEXlogicClass.reserve_rebalance_gdo(_DataSet, _TargetDataTableName);
            break;
          case "reserve_rebalance_oth":
            CalcEXlogicClass.reserve_rebalance_oth(_DataSet, _TargetDataTableName);
            break;
        }
        flag = true;
      }
      catch (Exception ex)
      {
        flag = true;
      }
      return flag;
    }

    private static void regional_initial_allocation_fixed(
      DataSet _DataSet,
      string _TargetDataTableName)
    {
      DataTable table = _DataSet.Tables[_TargetDataTableName];
      DataTable dataTable1 = new DataTable();
      DataTable dataTable2 = ((IEnumerable<DataRow>) table.Select("a>0 and d>0 and e>0")).CopyToDataTable<DataRow>();
      table.Rows.Clear();
      dataTable2.Columns.Add("SKU");
      foreach (DataRow row in (InternalDataCollectionBase) dataTable2.Rows)
      {
        string str = row["LOCATION_SKU_SIZE"].ToString();
        int startIndex = str.IndexOf("_", 0, str.Length) + 1;
        int length = str.Length;
        if (startIndex <= 0)
          row["a"] = (object) -1;
        else
          row["SKU"] = (object) str.ToString().Substring(startIndex, length - startIndex);
      }
      DataTable dataTable3 = new DataTable();
      int num1 = 0;
      int num2 = 0;
      foreach (string str in dataTable2.AsEnumerable().Select<DataRow, string>((System.Func<DataRow, string>) (SKU => SKU[nameof (SKU)].ToString())).Distinct<string>().ToList<string>())
      {
        dataTable3.Clear();
        DataTable dataTable4 = ((IEnumerable<DataRow>) dataTable2.Select("SKU = '" + str + "'")).CopyToDataTable<DataRow>();
        dataTable4.DefaultView.Sort = "a asc";
        dataTable3 = dataTable4.DefaultView.ToTable();
        int int32 = Convert.ToInt32(dataTable3.Rows[0]["d"]);
        foreach (DataRow row1 in (InternalDataCollectionBase) dataTable3.Rows)
        {
          num1 = 0;
          int num3 = Math.Min(Convert.ToInt32(row1["e"]), int32);
          if (num3 > 0)
          {
            DataRow row2 = table.NewRow();
            row2["ID"] = (object) num2;
            row2["LOCATION_SKU_SIZE"] = (object) row1["LOCATION_SKU_SIZE"].ToString();
            row2["f"] = (object) num3;
            table.Rows.Add(row2);
            ++num2;
            int32 -= num3;
          }
        }
      }
    }

    private static void regional_initial_allocation_gdo(
      DataSet _DataSet,
      string _TargetDataTableName)
    {
      DataTable table = _DataSet.Tables[_TargetDataTableName];
      DataTable dataTable1 = new DataTable();
      DataTable dataTable2 = ((IEnumerable<DataRow>) table.Select("a>0 and d>0 and e>0")).CopyToDataTable<DataRow>();
      table.Rows.Clear();
      dataTable2.Columns.Add("SKU");
      foreach (DataRow row in (InternalDataCollectionBase) dataTable2.Rows)
      {
        string str = row["LOCATION_SKU_SIZE"].ToString();
        int startIndex = str.IndexOf("_", 0, str.Length) + 1;
        int length = str.Length;
        if (startIndex <= 0)
          row["a"] = (object) -1;
        else
          row["SKU"] = (object) str.ToString().Substring(startIndex, length - startIndex);
      }
      DataTable dataTable3 = new DataTable();
      int num1 = 0;
      int num2 = 0;
      foreach (string str in dataTable2.AsEnumerable().Select<DataRow, string>((System.Func<DataRow, string>) (SKU => SKU[nameof (SKU)].ToString())).Distinct<string>().ToList<string>())
      {
        dataTable3.Clear();
        DataTable dataTable4 = ((IEnumerable<DataRow>) dataTable2.Select("SKU = '" + str + "'")).CopyToDataTable<DataRow>();
        dataTable4.DefaultView.Sort = "b desc, a asc";
        dataTable3 = dataTable4.DefaultView.ToTable();
        int int32 = Convert.ToInt32(dataTable3.Rows[0]["d"]);
        foreach (DataRow row1 in (InternalDataCollectionBase) dataTable3.Rows)
        {
          num1 = 0;
          int num3 = Math.Min(Convert.ToInt32(row1["e"]), int32);
          if (num3 > 0)
          {
            DataRow row2 = table.NewRow();
            row2["ID"] = (object) num2;
            row2["LOCATION_SKU_SIZE"] = (object) row1["LOCATION_SKU_SIZE"].ToString();
            row2["f"] = (object) num3;
            table.Rows.Add(row2);
            ++num2;
            int32 -= num3;
          }
        }
      }
    }

    private static void regional_rpl_gdo_buying_reserve(
      DataSet _DataSet,
      string _TargetDataTableName)
    {
      DataTable table = _DataSet.Tables[_TargetDataTableName];
      DataTable dataTable1 = new DataTable();
      DataTable dataTable2 = ((IEnumerable<DataRow>) table.Select("a>0 and g>0 and i =0")).CopyToDataTable<DataRow>();
      table.Rows.Clear();
      dataTable2.Columns.Add(new DataColumn("SKU", typeof (string)));
      dataTable2.Columns.Add(new DataColumn("NEED", typeof (int)));
      foreach (DataRow row in (InternalDataCollectionBase) dataTable2.Rows)
      {
        string str = row["LOCATION_SKU_SIZE"].ToString();
        int startIndex = str.IndexOf("_", 0, str.Length) + 1;
        int length = str.Length;
        if (startIndex <= 0)
          row["a"] = (object) -1;
        else
          row["SKU"] = (object) str.ToString().Substring(startIndex, length - startIndex);
        row["NEED"] = (object) Convert.ToInt32(Math.Max(Convert.ToInt32(row["g"]) - Convert.ToInt32(row["h"]), 0));
      }
      DataTable dataTable3 = dataTable2.Clone();
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      int num4 = 0;
      int num5 = 0;
      int num6 = 0;
      foreach (string str in dataTable2.AsEnumerable().Select<DataRow, string>((System.Func<DataRow, string>) (SKU => SKU[nameof (SKU)].ToString())).Distinct<string>().ToList<string>())
      {
        dataTable3.Rows.Clear();
        dataTable3 = ((IEnumerable<DataRow>) dataTable2.Select("SKU='" + str + "'")).CopyToDataTable<DataRow>();
        int val2 = 0;
        foreach (DataRow row in (InternalDataCollectionBase) dataTable3.Rows)
          val2 += Convert.ToInt32(row["f"]);
        num1 = 0;
        int int32_1 = Convert.ToInt32(Math.Min(Convert.ToInt32(dataTable3.Rows[0]["d"]), val2));
        num2 = 0;
        int int32_2 = Convert.ToInt32(Math.Max(Convert.ToInt32(dataTable3.Rows[0]["d"]) - int32_1, 0));
        int num7 = 0;
        foreach (DataRow row in (InternalDataCollectionBase) dataTable3.Rows)
          num7 += Convert.ToInt32(row["NEED"]);
        if ((int32_1 > 0 || int32_2 > 0) && ((IEnumerable<DataRow>) dataTable3.Select("a>0 and NEED>0")).Count<DataRow>() > 0)
        {
          DataTable dataTable4 = ((IEnumerable<DataRow>) dataTable3.Select("a>0 and NEED>0")).CopyToDataTable<DataRow>();
          dataTable4.DefaultView.Sort = "e desc, a asc";
          dataTable3 = dataTable4.DefaultView.ToTable();
          int num8 = 1;
          int num9 = 0;
          while (num8 > 0)
          {
            foreach (DataRow row1 in (InternalDataCollectionBase) dataTable3.Rows)
            {
              if (int32_1 > 0 || int32_2 > 0)
              {
                if (Convert.ToInt32(row1["NEED"]) > 0)
                {
                  int val1_1 = Math.Min(Convert.ToInt32(row1["NEED"]), Convert.ToInt32(row1["f"]));
                  int val1_2 = Math.Max(Convert.ToInt32(row1["NEED"]) - val1_1, 0);
                  int num10 = 0;
                  if (val1_1 > 0 && num10 == 0)
                  {
                    num3 = 0;
                    int num11 = Math.Min(Math.Min(val1_1, int32_1), 1);
                    if (num11 > 0)
                    {
                      DataRow row2 = table.NewRow();
                      row2["ID"] = (object) num6;
                      row2["LOCATION_SKU_SIZE"] = (object) row1["LOCATION_SKU_SIZE"].ToString();
                      row2["j"] = (object) num11;
                      table.Rows.Add(row2);
                      ++num6;
                      num7 -= num11;
                      int32_1 -= num11;
                      num4 = val1_1 - num11;
                      row1.BeginEdit();
                      row1["NEED"] = (object) (Convert.ToInt32(row1["NEED"]) - num11);
                      row1["f"] = (object) (Convert.ToInt32(row1["f"]) - num11);
                      row1.EndEdit();
                      continue;
                    }
                    num3 = 0;
                    num10 = Math.Min(Math.Min(val1_1, int32_2), 1);
                    if (num10 > 0)
                    {
                      DataRow row3 = table.NewRow();
                      row3["ID"] = (object) num6;
                      row3["LOCATION_SKU_SIZE"] = (object) row1["LOCATION_SKU_SIZE"].ToString();
                      row3["j"] = (object) num10;
                      table.Rows.Add(row3);
                      ++num6;
                      num7 -= num10;
                      int32_2 -= num10;
                      num4 = val1_1 - num10;
                      row1.BeginEdit();
                      row1["NEED"] = (object) (Convert.ToInt32(row1["NEED"]) - num10);
                      row1["f"] = (object) (Convert.ToInt32(row1["f"]) - num10);
                      row1.EndEdit();
                      continue;
                    }
                  }
                  if (val1_2 > 0 && num10 == 0)
                  {
                    num3 = 0;
                    int num12 = Math.Min(Math.Min(val1_2, int32_2), 1);
                    if (num12 > 0)
                    {
                      DataRow row4 = table.NewRow();
                      row4["ID"] = (object) num6;
                      row4["LOCATION_SKU_SIZE"] = (object) row1["LOCATION_SKU_SIZE"].ToString();
                      row4["j"] = (object) num12;
                      table.Rows.Add(row4);
                      ++num6;
                      num7 -= num12;
                      int32_2 -= num12;
                      num5 = val1_2 - num12;
                      row1.BeginEdit();
                      row1["NEED"] = (object) (Convert.ToInt32(row1["NEED"]) - num12);
                      row1.EndEdit();
                    }
                  }
                }
              }
              else
                break;
            }
            ++num9;
            if (num9 > 300)
              num8 = 0;
          }
        }
      }
    }

    private static void regional_rpl_fixed_buying_reserve(
      DataSet _DataSet,
      string _TargetDataTableName)
    {
      DataTable table = _DataSet.Tables[_TargetDataTableName];
      DataTable dataTable1 = new DataTable();
      DataTable dataTable2 = ((IEnumerable<DataRow>) table.Select("a>0 and g>0 and i =0")).CopyToDataTable<DataRow>();
      table.Rows.Clear();
      dataTable2.Columns.Add(new DataColumn("SKU", typeof (string)));
      dataTable2.Columns.Add(new DataColumn("NEED", typeof (int)));
      dataTable2.Columns.Add(new DataColumn("BUYING", typeof (int)));
      foreach (DataRow row in (InternalDataCollectionBase) dataTable2.Rows)
      {
        string str = row["LOCATION_SKU_SIZE"].ToString();
        int startIndex = str.IndexOf("_", 0, str.Length) + 1;
        int length = str.Length;
        if (startIndex <= 0)
          row["a"] = (object) -1;
        else
          row["SKU"] = (object) str.ToString().Substring(startIndex, length - startIndex);
        row["NEED"] = (object) Math.Max(Convert.ToInt32(row["g"]) - Convert.ToInt32(row["h"]), 0);
        row["BUYING"] = (object) Convert.ToInt32(row["f"]);
      }
      DataTable dataTable3 = new DataTable();
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      int num4 = 0;
      int num5 = 0;
      int num6 = 0;
      int num7 = 0;
      foreach (string str in dataTable2.AsEnumerable().Select<DataRow, string>((System.Func<DataRow, string>) (SKU => SKU[nameof (SKU)].ToString())).Distinct<string>().ToList<string>())
      {
        dataTable3.Rows.Clear();
        dataTable3 = ((IEnumerable<DataRow>) dataTable2.Select("SKU='" + str + "'")).CopyToDataTable<DataRow>();
        num1 = 0;
        int int32_1 = Convert.ToInt32(Math.Min(Convert.ToInt32(dataTable3.Rows[0]["d"]), Convert.ToInt32(dataTable3.Compute("Sum(BUYING)", ""))));
        num2 = 0;
        int int32_2 = Convert.ToInt32(Math.Max(Convert.ToInt32(dataTable3.Rows[0]["d"]) - int32_1, 0));
        num3 = 0;
        int int32_3 = Convert.ToInt32(dataTable3.Compute("Sum(NEED)", ""));
        if ((int32_1 > 0 || int32_2 > 0) && ((IEnumerable<DataRow>) dataTable3.Select("a>0 and NEED>0")).Count<DataRow>() > 0)
        {
          DataTable dataTable4 = ((IEnumerable<DataRow>) dataTable3.Select("a>0 and NEED>0")).CopyToDataTable<DataRow>();
          dataTable4.DefaultView.Sort = "a asc";
          dataTable3 = dataTable4.DefaultView.ToTable();
          int num8 = 1;
          int num9 = 0;
          while (num8 > 0)
          {
            foreach (DataRow row1 in (InternalDataCollectionBase) dataTable3.Rows)
            {
              if (int32_1 > 0 || int32_2 > 0)
              {
                if (Convert.ToInt32(row1["NEED"]) > 0)
                {
                  int val1_1 = Math.Min(Convert.ToInt32(row1["NEED"]), Convert.ToInt32(row1["BUYING"]));
                  int val1_2 = Math.Max(Convert.ToInt32(row1["NEED"]) - val1_1, 0);
                  int num10 = 0;
                  if (val1_1 > 0 && num10 == 0)
                  {
                    num4 = 0;
                    int num11 = Math.Min(val1_1, int32_1);
                    if (num11 > 0)
                    {
                      DataRow row2 = table.NewRow();
                      row2["ID"] = (object) num7;
                      row2["LOCATION_SKU_SIZE"] = (object) row1["LOCATION_SKU_SIZE"].ToString();
                      row2["j"] = (object) num11;
                      table.Rows.Add(row2);
                      ++num7;
                      int32_3 -= num11;
                      int32_1 -= num11;
                      val1_1 -= num11;
                      row1.BeginEdit();
                      row1["NEED"] = (object) (Convert.ToInt32(row1["NEED"]) - num11);
                      row1["BUYING"] = (object) (Convert.ToInt32(row1["BUYING"]) - num11);
                      row1.EndEdit();
                    }
                    num4 = 0;
                    num10 = Math.Min(val1_1, int32_2);
                    if (num10 > 0)
                    {
                      DataRow row3 = table.NewRow();
                      row3["ID"] = (object) num7;
                      row3["LOCATION_SKU_SIZE"] = (object) row1["LOCATION_SKU_SIZE"].ToString();
                      row3["j"] = (object) num10;
                      table.Rows.Add(row3);
                      ++num7;
                      int32_3 -= num10;
                      int32_2 -= num10;
                      num5 = val1_1 - num10;
                      row1.BeginEdit();
                      row1["NEED"] = (object) (Convert.ToInt32(row1["NEED"]) - num10);
                      row1["BUYING"] = (object) (Convert.ToInt32(row1["BUYING"]) - num10);
                      row1.EndEdit();
                    }
                  }
                  if (val1_2 > 0 && num10 == 0)
                  {
                    num4 = 0;
                    int num12 = Math.Min(val1_2, int32_2);
                    if (num12 > 0)
                    {
                      DataRow row4 = table.NewRow();
                      row4["ID"] = (object) num7;
                      row4["LOCATION_SKU_SIZE"] = (object) row1["LOCATION_SKU_SIZE"].ToString();
                      row4["j"] = (object) num12;
                      table.Rows.Add(row4);
                      ++num7;
                      int32_3 -= num12;
                      int32_2 -= num12;
                      num6 = val1_2 - num12;
                      row1.BeginEdit();
                      row1["NEED"] = (object) (Convert.ToInt32(row1["NEED"]) - num12);
                      row1.EndEdit();
                    }
                  }
                }
              }
              else
                break;
            }
            ++num9;
            if (num9 > 300)
              num8 = 0;
          }
        }
      }
    }

    private static void regional_rpl_stockout_buying_reserve(
      DataSet _DataSet,
      string _TargetDataTableName)
    {
      DataTable table = _DataSet.Tables[_TargetDataTableName];
      DataTable dataTable1 = new DataTable();
      DataTable dataTable2 = ((IEnumerable<DataRow>) table.Select("a>0 and g>0 and i =0")).CopyToDataTable<DataRow>();
      table.Rows.Clear();
      dataTable2.Columns.Add(new DataColumn("SKU", typeof (string)));
      dataTable2.Columns.Add(new DataColumn("NEED", typeof (int)));
      foreach (DataRow row in (InternalDataCollectionBase) dataTable2.Rows)
      {
        string str = row["LOCATION_SKU_SIZE"].ToString();
        int startIndex = str.IndexOf("_", 0, str.Length) + 1;
        int length = str.Length;
        if (startIndex <= 0)
          row["a"] = (object) -1;
        else
          row["SKU"] = (object) str.ToString().Substring(startIndex, length - startIndex);
        int num = Convert.ToInt32(row["g"]) <= Convert.ToInt32(row["h"]) ? 0 : (Convert.ToInt32(row["h"]) == 0 ? 1 : 0);
        row["NEED"] = num == 0 ? (object) 0 : (object) 1;
      }
      DataTable dataTable3 = new DataTable();
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      int num4 = 0;
      int num5 = 0;
      int num6 = 0;
      int num7 = 0;
      foreach (string str in dataTable2.AsEnumerable().Select<DataRow, string>((System.Func<DataRow, string>) (SKU => SKU[nameof (SKU)].ToString())).Distinct<string>().ToList<string>())
      {
        dataTable3.Rows.Clear();
        dataTable3 = ((IEnumerable<DataRow>) dataTable2.Select("SKU='" + str + "'")).CopyToDataTable<DataRow>();
        num1 = 0;
        int int32_1 = Convert.ToInt32(Math.Min(Convert.ToInt32(dataTable3.Rows[0]["d"]), Convert.ToInt32(dataTable3.Compute("Sum(f)", ""))));
        num2 = 0;
        int int32_2 = Convert.ToInt32(Math.Max(Convert.ToInt32(dataTable3.Rows[0]["d"]) - int32_1, 0));
        num3 = 0;
        int int32_3 = Convert.ToInt32(dataTable3.Compute("Sum(NEED)", ""));
        if ((int32_1 > 0 || int32_2 > 0) && ((IEnumerable<DataRow>) dataTable3.Select("a>0 and NEED>0")).Count<DataRow>() > 0)
        {
          DataTable dataTable4 = ((IEnumerable<DataRow>) dataTable3.Select("a>0 and NEED>0")).CopyToDataTable<DataRow>();
          dataTable4.DefaultView.Sort = "a asc";
          dataTable3 = dataTable4.DefaultView.ToTable();
          int num8 = 1;
          int num9 = 0;
          while (num8 > 0)
          {
            foreach (DataRow row1 in (InternalDataCollectionBase) dataTable3.Rows)
            {
              if (int32_1 > 0 || int32_2 > 0)
              {
                if (Convert.ToInt32(row1["NEED"]) > 0)
                {
                  int val1_1 = Math.Min(Convert.ToInt32(row1["NEED"]), Convert.ToInt32(row1["f"]));
                  int val1_2 = Math.Max(Convert.ToInt32(row1["NEED"]) - val1_1, 0);
                  int num10 = 0;
                  if (val1_1 > 0 && num10 == 0)
                  {
                    num4 = 0;
                    int num11 = Math.Min(Math.Min(val1_1, int32_1), 1);
                    if (num11 > 0)
                    {
                      DataRow row2 = table.NewRow();
                      row2["ID"] = (object) num7;
                      row2["LOCATION_SKU_SIZE"] = (object) row1["LOCATION_SKU_SIZE"].ToString();
                      row2["j"] = (object) num11;
                      table.Rows.Add(row2);
                      ++num7;
                      int32_3 -= num11;
                      int32_1 -= num11;
                      num5 = val1_1 - num11;
                      row1.BeginEdit();
                      row1["NEED"] = (object) (Convert.ToInt32(row1["NEED"]) - num11);
                      row1["f"] = (object) (Convert.ToInt32(row1["f"]) - num11);
                      row1.EndEdit();
                      continue;
                    }
                    num4 = 0;
                    num10 = Math.Min(Math.Min(val1_1, int32_2), 1);
                    if (num10 > 0)
                    {
                      DataRow row3 = table.NewRow();
                      row3["ID"] = (object) num7;
                      row3["LOCATION_SKU_SIZE"] = (object) row1["LOCATION_SKU_SIZE"].ToString();
                      row3["j"] = (object) num10;
                      table.Rows.Add(row3);
                      ++num7;
                      int32_3 -= num10;
                      int32_2 -= num10;
                      num5 = val1_1 - num10;
                      row1.BeginEdit();
                      row1["NEED"] = (object) (Convert.ToInt32(row1["NEED"]) - num10);
                      row1["f"] = (object) (Convert.ToInt32(row1["f"]) - num10);
                      row1.EndEdit();
                      continue;
                    }
                  }
                  if (val1_2 > 0 && num10 == 0)
                  {
                    num4 = 0;
                    int num12 = Math.Min(Math.Min(val1_2, int32_2), 1);
                    if (num12 > 0)
                    {
                      DataRow row4 = table.NewRow();
                      row4["ID"] = (object) num7;
                      row4["LOCATION_SKU_SIZE"] = (object) row1["LOCATION_SKU_SIZE"].ToString();
                      row4["j"] = (object) num12;
                      table.Rows.Add(row4);
                      ++num7;
                      int32_3 -= num12;
                      int32_2 -= num12;
                      num6 = val1_2 - num12;
                      row1.BeginEdit();
                      row1["NEED"] = (object) (Convert.ToInt32(row1["NEED"]) - num12);
                      row1.EndEdit();
                    }
                  }
                }
              }
              else
                break;
            }
            ++num9;
            if (num9 > 300)
              num8 = 0;
          }
        }
      }
    }

    private static void regional_rpl_woh_buying_reserve(
      DataSet _DataSet,
      string _TargetDataTableName)
    {
      DataTable table = _DataSet.Tables[_TargetDataTableName];
      DataTable dataTable1 = new DataTable();
      DataTable dataTable2 = ((IEnumerable<DataRow>) table.Select("a>0 and g>0 and i =0")).CopyToDataTable<DataRow>();
      table.Rows.Clear();
      dataTable2.Columns.Add(new DataColumn("SKU", typeof (string)));
      dataTable2.Columns.Add(new DataColumn("NEED", typeof (int)));
      dataTable2.Columns.Add(new DataColumn("POH", typeof (int)));
      dataTable2.Columns.Add(new DataColumn("WOH", typeof (double)));
      foreach (DataRow row in (InternalDataCollectionBase) dataTable2.Rows)
      {
        string str = row["LOCATION_SKU_SIZE"].ToString();
        int startIndex = str.IndexOf("_", 0, str.Length) + 1;
        int length = str.Length;
        if (startIndex <= 0)
          row["a"] = (object) -1;
        else
          row["SKU"] = (object) str.ToString().Substring(startIndex, length - startIndex);
        row["NEED"] = (object) Math.Max(Convert.ToInt32(row["g"]) - Convert.ToInt32(row["h"]), 0);
        row["POH"] = (object) Convert.ToInt32(row["h"]);
        if (Convert.ToDouble(row["e"]) == 0.0 && Convert.ToInt32(row["POH"]) == 0)
        {
          row["WOH"] = (object) 0;
        }
        else
        {
          int num = Convert.ToDouble(row["e"]) != 0.0 ? 0 : (Convert.ToInt32(row["POH"]) > 0 ? 1 : 0);
          row["WOH"] = num == 0 ? (object) (Convert.ToDouble(row["POH"]) / Convert.ToDouble(row["e"])) : (object) 99999;
        }
      }
      DataTable dataTable3 = new DataTable();
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      int num4 = 0;
      int num5 = 0;
      int num6 = 0;
      int num7 = 0;
      foreach (string str in dataTable2.AsEnumerable().Select<DataRow, string>((System.Func<DataRow, string>) (SKU => SKU[nameof (SKU)].ToString())).Distinct<string>().ToList<string>())
      {
        dataTable3.Rows.Clear();
        dataTable3 = ((IEnumerable<DataRow>) dataTable2.Select("SKU='" + str + "'")).CopyToDataTable<DataRow>();
        num1 = 0;
        int int32_1 = Convert.ToInt32(Math.Min(Convert.ToInt32(dataTable3.Rows[0]["d"]), Convert.ToInt32(dataTable3.Compute("Sum(f)", ""))));
        num2 = 0;
        int int32_2 = Convert.ToInt32(Math.Max(Convert.ToInt32(dataTable3.Rows[0]["d"]) - int32_1, 0));
        num3 = 0;
        int int32_3 = Convert.ToInt32(dataTable3.Compute("Sum(NEED)", ""));
        if ((int32_1 > 0 || int32_2 > 0) && ((IEnumerable<DataRow>) dataTable3.Select("a>0 and NEED>0")).Count<DataRow>() > 0)
        {
          dataTable3 = ((IEnumerable<DataRow>) dataTable3.Select("a>0 and NEED>0")).CopyToDataTable<DataRow>();
          int num8 = 1;
          int num9 = 0;
          while (num8 > 0)
          {
            dataTable3.DefaultView.Sort = "WOH asc, a asc";
            dataTable3 = dataTable3.DefaultView.ToTable();
            foreach (DataRow row1 in (InternalDataCollectionBase) dataTable3.Rows)
            {
              if (int32_1 > 0 || int32_2 > 0)
              {
                if (Convert.ToInt32(row1["NEED"]) > 0)
                {
                  int val1_1 = Math.Min(Convert.ToInt32(row1["NEED"]), Convert.ToInt32(row1["f"]));
                  int val1_2 = Math.Max(Convert.ToInt32(row1["NEED"]) - val1_1, 0);
                  int num10 = 0;
                  if (val1_1 > 0 && num10 == 0)
                  {
                    num4 = 0;
                    int num11 = Math.Min(Math.Min(val1_1, int32_1), 1);
                    if (num11 > 0)
                    {
                      DataRow row2 = table.NewRow();
                      row2["ID"] = (object) num7;
                      row2["LOCATION_SKU_SIZE"] = (object) row1["LOCATION_SKU_SIZE"].ToString();
                      row2["j"] = (object) num11;
                      table.Rows.Add(row2);
                      ++num7;
                      int32_3 -= num11;
                      int32_1 -= num11;
                      num5 = val1_1 - num11;
                      row1.BeginEdit();
                      row1["NEED"] = (object) (Convert.ToInt32(row1["NEED"]) - num11);
                      row1["f"] = (object) (Convert.ToInt32(row1["f"]) - num11);
                      row1["POH"] = (object) (Convert.ToInt32(row1["POH"]) + num11);
                      if (Convert.ToDouble(row1["e"]) == 0.0 && Convert.ToInt32(row1["POH"]) == 0)
                      {
                        row1["WOH"] = (object) 0;
                      }
                      else
                      {
                        int num12 = Convert.ToDouble(row1["e"]) != 0.0 ? 0 : (Convert.ToInt32(row1["POH"]) > 0 ? 1 : 0);
                        row1["WOH"] = num12 == 0 ? (object) (Convert.ToDouble(row1["POH"]) / Convert.ToDouble(row1["e"])) : (object) 99999;
                      }
                      row1.EndEdit();
                      continue;
                    }
                    num4 = 0;
                    num10 = Math.Min(Math.Min(val1_1, int32_2), 1);
                    if (num10 > 0)
                    {
                      DataRow row3 = table.NewRow();
                      row3["ID"] = (object) num7;
                      row3["LOCATION_SKU_SIZE"] = (object) row1["LOCATION_SKU_SIZE"].ToString();
                      row3["j"] = (object) num10;
                      table.Rows.Add(row3);
                      ++num7;
                      int32_3 -= num10;
                      int32_2 -= num10;
                      num5 = val1_1 - num10;
                      row1.BeginEdit();
                      row1["NEED"] = (object) (Convert.ToInt32(row1["NEED"]) - num10);
                      row1["f"] = (object) (Convert.ToInt32(row1["f"]) - num10);
                      row1["POH"] = (object) (Convert.ToInt32(row1["POH"]) + num10);
                      if (Convert.ToDouble(row1["e"]) == 0.0 && Convert.ToInt32(row1["POH"]) == 0)
                      {
                        row1["WOH"] = (object) 0;
                      }
                      else
                      {
                        int num13 = Convert.ToDouble(row1["e"]) != 0.0 ? 0 : (Convert.ToInt32(row1["POH"]) > 0 ? 1 : 0);
                        row1["WOH"] = num13 == 0 ? (object) (Convert.ToDouble(row1["POH"]) / Convert.ToDouble(row1["e"])) : (object) 99999;
                      }
                      row1.EndEdit();
                      continue;
                    }
                  }
                  if (val1_2 > 0 && num10 == 0)
                  {
                    num4 = 0;
                    int num14 = Math.Min(Math.Min(val1_2, int32_2), 1);
                    if (num14 > 0)
                    {
                      DataRow row4 = table.NewRow();
                      row4["ID"] = (object) num7;
                      row4["LOCATION_SKU_SIZE"] = (object) row1["LOCATION_SKU_SIZE"].ToString();
                      row4["j"] = (object) num14;
                      table.Rows.Add(row4);
                      ++num7;
                      int32_3 -= num14;
                      int32_2 -= num14;
                      num6 = val1_2 - num14;
                      row1.BeginEdit();
                      row1["NEED"] = (object) (Convert.ToInt32(row1["NEED"]) - num14);
                      row1["POH"] = (object) (Convert.ToInt32(row1["POH"]) + num14);
                      if (Convert.ToDouble(row1["e"]) == 0.0 && Convert.ToInt32(row1["POH"]) == 0)
                      {
                        row1["WOH"] = (object) 0;
                      }
                      else
                      {
                        int num15 = Convert.ToDouble(row1["e"]) != 0.0 ? 0 : (Convert.ToInt32(row1["POH"]) > 0 ? 1 : 0);
                        row1["WOH"] = num15 == 0 ? (object) (Convert.ToDouble(row1["POH"]) / Convert.ToDouble(row1["e"])) : (object) 99999;
                      }
                      row1.EndEdit();
                    }
                  }
                }
              }
              else
                break;
            }
            ++num9;
            if (num9 > 50)
              num8 = 0;
          }
        }
      }
    }

    private static void regional_rpl_wohsub_buying_reserve(
      DataSet _DataSet,
      string _TargetDataTableName)
    {
      DataTable table = _DataSet.Tables[_TargetDataTableName];
      DataTable dataTable1 = new DataTable();
      DataTable dataTable2 = ((IEnumerable<DataRow>) table.Select("a>0 and g>0 and i =0")).CopyToDataTable<DataRow>();
      table.Rows.Clear();
      dataTable2.Columns.Add(new DataColumn("SKU", typeof (string)));
      dataTable2.Columns.Add(new DataColumn("NEED", typeof (int)));
      foreach (DataRow row in (InternalDataCollectionBase) dataTable2.Rows)
      {
        string str = row["LOCATION_SKU_SIZE"].ToString();
        int startIndex = str.IndexOf("_", 0, str.Length) + 1;
        int length = str.Length;
        if (startIndex <= 0)
          row["a"] = (object) -1;
        else
          row["SKU"] = (object) str.ToString().Substring(startIndex, length - startIndex);
        row["NEED"] = (object) Math.Max(Convert.ToInt32(row["g"]) - Convert.ToInt32(row["h"]), 0);
      }
      DataTable dataTable3 = new DataTable();
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      int num4 = 0;
      int num5 = 0;
      int num6 = 0;
      int num7 = 0;
      foreach (string str in dataTable2.AsEnumerable().Select<DataRow, string>((System.Func<DataRow, string>) (SKU => SKU[nameof (SKU)].ToString())).Distinct<string>().ToList<string>())
      {
        dataTable3.Rows.Clear();
        dataTable3 = ((IEnumerable<DataRow>) dataTable2.Select("SKU='" + str + "'")).CopyToDataTable<DataRow>();
        num1 = 0;
        int int32_1 = Convert.ToInt32(Math.Min(Convert.ToInt32(dataTable3.Rows[0]["d"]), Convert.ToInt32(dataTable3.Compute("Sum(f)", ""))));
        num2 = 0;
        int int32_2 = Convert.ToInt32(Math.Max(Convert.ToInt32(dataTable3.Rows[0]["d"]) - int32_1, 0));
        num3 = 0;
        int int32_3 = Convert.ToInt32(dataTable3.Compute("Sum(NEED)", ""));
        if ((int32_1 > 0 || int32_2 > 0) && ((IEnumerable<DataRow>) dataTable3.Select("a>0 and NEED>0")).Count<DataRow>() > 0)
        {
          DataTable dataTable4 = ((IEnumerable<DataRow>) dataTable3.Select("a>0 and NEED>0")).CopyToDataTable<DataRow>();
          dataTable4.DefaultView.Sort = "e asc, a asc";
          dataTable3 = dataTable4.DefaultView.ToTable();
          int num8 = 1;
          int num9 = 0;
          while (num8 > 0)
          {
            foreach (DataRow row1 in (InternalDataCollectionBase) dataTable3.Rows)
            {
              if (int32_1 > 0 || int32_2 > 0)
              {
                if (Convert.ToInt32(row1["NEED"]) > 0)
                {
                  int val1_1 = Math.Min(Convert.ToInt32(row1["NEED"]), Convert.ToInt32(row1["f"]));
                  int val1_2 = Math.Max(Convert.ToInt32(row1["NEED"]) - val1_1, 0);
                  int num10 = 0;
                  if (val1_1 > 0 && num10 == 0)
                  {
                    num4 = 0;
                    int num11 = Math.Min(val1_1, int32_1);
                    if (num11 > 0)
                    {
                      DataRow row2 = table.NewRow();
                      row2["ID"] = (object) num7;
                      row2["LOCATION_SKU_SIZE"] = (object) row1["LOCATION_SKU_SIZE"].ToString();
                      row2["j"] = (object) num11;
                      table.Rows.Add(row2);
                      ++num7;
                      int32_3 -= num11;
                      int32_1 -= num11;
                      val1_1 -= num11;
                      row1.BeginEdit();
                      row1["NEED"] = (object) (Convert.ToInt32(row1["NEED"]) - num11);
                      row1["f"] = (object) (Convert.ToInt32(row1["f"]) - num11);
                      row1.EndEdit();
                    }
                    num4 = 0;
                    num10 = Math.Min(val1_1, int32_2);
                    if (num10 > 0)
                    {
                      DataRow row3 = table.NewRow();
                      row3["ID"] = (object) num7;
                      row3["LOCATION_SKU_SIZE"] = (object) row1["LOCATION_SKU_SIZE"].ToString();
                      row3["j"] = (object) num10;
                      table.Rows.Add(row3);
                      ++num7;
                      int32_3 -= num10;
                      int32_2 -= num10;
                      num5 = val1_1 - num10;
                      row1.BeginEdit();
                      row1["NEED"] = (object) (Convert.ToInt32(row1["NEED"]) - num10);
                      row1["f"] = (object) (Convert.ToInt32(row1["f"]) - num10);
                      row1.EndEdit();
                    }
                  }
                  if (val1_2 > 0 && num10 == 0)
                  {
                    num4 = 0;
                    int num12 = Math.Min(val1_2, int32_2);
                    if (num12 > 0)
                    {
                      DataRow row4 = table.NewRow();
                      row4["ID"] = (object) num7;
                      row4["LOCATION_SKU_SIZE"] = (object) row1["LOCATION_SKU_SIZE"].ToString();
                      row4["j"] = (object) num12;
                      table.Rows.Add(row4);
                      ++num7;
                      int32_3 -= num12;
                      int32_2 -= num12;
                      num6 = val1_2 - num12;
                      row1.BeginEdit();
                      row1["NEED"] = (object) (Convert.ToInt32(row1["NEED"]) - num12);
                      row1.EndEdit();
                    }
                  }
                }
              }
              else
                break;
            }
            ++num9;
            if (num9 > 300)
              num8 = 0;
          }
        }
      }
    }

    private static void regional_rpl_gdowoh_buying_reserve(
      DataSet _DataSet,
      string _TargetDataTableName)
    {
      DataTable table = _DataSet.Tables[_TargetDataTableName];
      DataTable dataTable1 = new DataTable();
      DataTable dataTable2 = ((IEnumerable<DataRow>) table.Select("aa>0 and g>0 and i =0")).CopyToDataTable<DataRow>();
      table.Rows.Clear();
      dataTable2.Columns.Add(new DataColumn("SKU", typeof (string)));
      dataTable2.Columns.Add(new DataColumn("NEED", typeof (int)));
      dataTable2.Columns.Add(new DataColumn("POH", typeof (int)));
      dataTable2.Columns.Add(new DataColumn("WOH", typeof (double)));
      foreach (DataRow row in (InternalDataCollectionBase) dataTable2.Rows)
      {
        string str = row["LOCATION_SKU_SIZE"].ToString();
        int startIndex = str.IndexOf("_", 0, str.Length) + 1;
        int length = str.Length;
        if (startIndex <= 0)
          row["a"] = (object) -1;
        else
          row["SKU"] = (object) str.ToString().Substring(startIndex, length - startIndex);
        row["NEED"] = (object) Math.Max(Convert.ToInt32(row["g"]) - Convert.ToInt32(row["h"]), 0);
        row["POH"] = (object) Convert.ToInt32(row["h"]);
        if (Convert.ToDouble(row["e"]) == 0.0 && Convert.ToInt32(row["POH"]) == 0)
        {
          row["WOH"] = (object) 0;
        }
        else
        {
          int num = Convert.ToDouble(row["e"]) != 0.0 ? 0 : (Convert.ToInt32(row["POH"]) > 0 ? 1 : 0);
          row["WOH"] = num == 0 ? (object) (Convert.ToDouble(row["POH"]) / Convert.ToDouble(row["e"])) : (object) 99999;
        }
      }
      DataTable dataTable3 = new DataTable();
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      int num4 = 0;
      int num5 = 0;
      int num6 = 0;
      int num7 = 0;
      foreach (string str in dataTable2.AsEnumerable().Select<DataRow, string>((System.Func<DataRow, string>) (SKU => SKU[nameof (SKU)].ToString())).Distinct<string>().ToList<string>())
      {
        dataTable3.Rows.Clear();
        dataTable3 = ((IEnumerable<DataRow>) dataTable2.Select("SKU='" + str + "'")).CopyToDataTable<DataRow>();
        num1 = 0;
        int int32_1 = Convert.ToInt32(Math.Min(Convert.ToInt32(dataTable3.Rows[0]["d"]), Convert.ToInt32(dataTable3.Compute("Sum(f)", ""))));
        num2 = 0;
        int int32_2 = Convert.ToInt32(Math.Max(Convert.ToInt32(dataTable3.Rows[0]["d"]) - int32_1, 0));
        num3 = 0;
        int int32_3 = Convert.ToInt32(dataTable3.Compute("Sum(NEED)", ""));
        if ((int32_1 > 0 || int32_2 > 0) && ((IEnumerable<DataRow>) dataTable3.Select("a>0 and NEED>0")).Count<DataRow>() > 0)
        {
          dataTable3 = ((IEnumerable<DataRow>) dataTable3.Select("a>0 and NEED>0")).CopyToDataTable<DataRow>();
          int num8 = 1;
          int num9 = 0;
          while (num8 > 0)
          {
            dataTable3.DefaultView.Sort = "e desc, WOH asc, a asc";
            dataTable3 = dataTable3.DefaultView.ToTable();
            foreach (DataRow row1 in (InternalDataCollectionBase) dataTable3.Rows)
            {
              if (int32_1 > 0 || int32_2 > 0)
              {
                if (Convert.ToInt32(row1["NEED"]) > 0)
                {
                  int val1_1 = Math.Min(Convert.ToInt32(row1["NEED"]), Convert.ToInt32(row1["f"]));
                  int val1_2 = Math.Max(Convert.ToInt32(row1["NEED"]) - val1_1, 0);
                  int num10 = 0;
                  if (val1_1 > 0 && num10 == 0)
                  {
                    num4 = 0;
                    int num11 = Math.Min(Math.Min(val1_1, int32_1), 1);
                    if (num11 > 0)
                    {
                      DataRow row2 = table.NewRow();
                      row2["ID"] = (object) num7;
                      row2["LOCATION_SKU_SIZE"] = (object) row1["LOCATION_SKU_SIZE"].ToString();
                      row2["j"] = (object) num11;
                      table.Rows.Add(row2);
                      ++num7;
                      int32_3 -= num11;
                      int32_1 -= num11;
                      num5 = val1_1 - num11;
                      row1.BeginEdit();
                      row1["NEED"] = (object) (Convert.ToInt32(row1["NEED"]) - num11);
                      row1["f"] = (object) (Convert.ToInt32(row1["f"]) - num11);
                      row1["POH"] = (object) (Convert.ToInt32(row1["POH"]) + num11);
                      if (Convert.ToDouble(row1["e"]) == 0.0 && Convert.ToInt32(row1["POH"]) == 0)
                      {
                        row1["WOH"] = (object) 0;
                      }
                      else
                      {
                        int num12 = Convert.ToDouble(row1["e"]) != 0.0 ? 0 : (Convert.ToInt32(row1["POH"]) > 0 ? 1 : 0);
                        row1["WOH"] = num12 == 0 ? (object) (Convert.ToDouble(row1["POH"]) / Convert.ToDouble(row1["e"])) : (object) 99999;
                      }
                      row1.EndEdit();
                      continue;
                    }
                    num4 = 0;
                    num10 = Math.Min(Math.Min(val1_1, int32_2), 1);
                    if (num10 > 0)
                    {
                      DataRow row3 = table.NewRow();
                      row3["ID"] = (object) num7;
                      row3["LOCATION_SKU_SIZE"] = (object) row1["LOCATION_SKU_SIZE"].ToString();
                      row3["j"] = (object) num10;
                      table.Rows.Add(row3);
                      ++num7;
                      int32_3 -= num10;
                      int32_2 -= num10;
                      num5 = val1_1 - num10;
                      row1.BeginEdit();
                      row1["NEED"] = (object) (Convert.ToInt32(row1["NEED"]) - num10);
                      row1["f"] = (object) (Convert.ToInt32(row1["f"]) - num10);
                      row1["POH"] = (object) (Convert.ToInt32(row1["POH"]) + num10);
                      if (Convert.ToDouble(row1["e"]) == 0.0 && Convert.ToInt32(row1["POH"]) == 0)
                      {
                        row1["WOH"] = (object) 0;
                      }
                      else
                      {
                        int num13 = Convert.ToDouble(row1["e"]) != 0.0 ? 0 : (Convert.ToInt32(row1["POH"]) > 0 ? 1 : 0);
                        row1["WOH"] = num13 == 0 ? (object) (Convert.ToDouble(row1["POH"]) / (double) Convert.ToInt32(row1["e"])) : (object) 99999;
                      }
                      row1.EndEdit();
                      continue;
                    }
                  }
                  if (val1_2 > 0 && num10 == 0)
                  {
                    num4 = 0;
                    int num14 = Math.Min(Math.Min(val1_2, int32_2), 1);
                    if (num14 > 0)
                    {
                      DataRow row4 = table.NewRow();
                      row4["ID"] = (object) num7;
                      row4["LOCATION_SKU_SIZE"] = (object) row1["LOCATION_SKU_SIZE"].ToString();
                      row4["j"] = (object) num14;
                      table.Rows.Add(row4);
                      ++num7;
                      int32_3 -= num14;
                      int32_2 -= num14;
                      num6 = val1_2 - num14;
                      row1.BeginEdit();
                      row1["NEED"] = (object) (Convert.ToInt32(row1["NEED"]) - num14);
                      row1["POH"] = (object) (Convert.ToInt32(row1["POH"]) + num14);
                      if (Convert.ToDouble(row1["e"]) == 0.0 && Convert.ToInt32(row1["POH"]) == 0)
                      {
                        row1["WOH"] = (object) 0;
                      }
                      else
                      {
                        int num15 = Convert.ToDouble(row1["e"]) != 0.0 ? 0 : (Convert.ToInt32(row1["POH"]) > 0 ? 1 : 0);
                        row1["WOH"] = num15 == 0 ? (object) (Convert.ToDouble(row1["POH"]) / (double) Convert.ToInt32(row1["e"])) : (object) 99999;
                      }
                      row1.EndEdit();
                    }
                  }
                }
              }
              else
                break;
            }
            ++num9;
            if (num9 > 50)
              num8 = 0;
          }
        }
      }
    }

    private static void regional_push_gdo(DataSet _DataSet, string _TargetDataTableName)
    {
      DataTable table = _DataSet.Tables[_TargetDataTableName];
      DataTable dataTable1 = new DataTable();
      DataTable dataTable2 = ((IEnumerable<DataRow>) table.Select("a>0 and c>0 and f>0")).CopyToDataTable<DataRow>();
      table.Rows.Clear();
      dataTable2.Columns.Add(new DataColumn("SKU", typeof (string)));
      dataTable2.Columns.Add(new DataColumn("POH", typeof (int)));
      dataTable2.Columns.Add(new DataColumn("WOH", typeof (double)));
      foreach (DataRow row in (InternalDataCollectionBase) dataTable2.Rows)
      {
        string str = row["LOCATION_SKU_SIZE"].ToString();
        int startIndex = str.IndexOf("_", 0, str.Length) + 1;
        int length = str.Length;
        if (startIndex <= 0)
          row["a"] = (object) -1;
        else
          row["SKU"] = (object) str.ToString().Substring(startIndex, length - startIndex);
      }
      DataTable dataTable3 = dataTable2.Clone();
      int num1 = 0;
      int num2 = 0;
      foreach (string str in dataTable2.AsEnumerable().Select<DataRow, string>((System.Func<DataRow, string>) (SKU => SKU[nameof (SKU)].ToString())).Distinct<string>().ToList<string>())
      {
        dataTable3.Rows.Clear();
        DataTable dataTable4 = ((IEnumerable<DataRow>) dataTable2.Select("SKU='" + str + "'")).CopyToDataTable<DataRow>();
        dataTable4.DefaultView.Sort = "d desc, a asc";
        dataTable3 = dataTable4.DefaultView.ToTable();
        num1 = 0;
        int int32 = Convert.ToInt32(dataTable3.Rows[0]["f"]);
        foreach (DataRow row1 in (InternalDataCollectionBase) dataTable3.Rows)
        {
          if (int32 > 0)
          {
            int num3 = 1;
            DataRow row2 = table.NewRow();
            row2["ID"] = (object) num2;
            row2["LOCATION_SKU_SIZE"] = (object) row1["LOCATION_SKU_SIZE"].ToString();
            row2["g"] = (object) num3;
            table.Rows.Add(row2);
            int32 -= num3;
            ++num2;
          }
          else
            break;
        }
      }
    }

    private static void regional_push_fixed(DataSet _DataSet, string _TargetDataTableName)
    {
      DataTable table = _DataSet.Tables[_TargetDataTableName];
      DataTable dataTable1 = new DataTable();
      DataTable dataTable2 = ((IEnumerable<DataRow>) table.Select("a>0 and c>0 and f>0")).CopyToDataTable<DataRow>();
      table.Rows.Clear();
      dataTable2.Columns.Add(new DataColumn("SKU", typeof (string)));
      dataTable2.Columns.Add(new DataColumn("POH", typeof (int)));
      dataTable2.Columns.Add(new DataColumn("WOH", typeof (double)));
      foreach (DataRow row in (InternalDataCollectionBase) dataTable2.Rows)
      {
        string str = row["LOCATION_SKU_SIZE"].ToString();
        int startIndex = str.IndexOf("_", 0, str.Length) + 1;
        int length = str.Length;
        if (startIndex <= 0)
          row["a"] = (object) -1;
        else
          row["SKU"] = (object) str.ToString().Substring(startIndex, length - startIndex);
      }
      DataTable dataTable3 = dataTable2.Clone();
      int num1 = 0;
      int num2 = 0;
      foreach (string str in dataTable2.AsEnumerable().Select<DataRow, string>((System.Func<DataRow, string>) (SKU => SKU[nameof (SKU)].ToString())).Distinct<string>().ToList<string>())
      {
        dataTable3.Rows.Clear();
        DataTable dataTable4 = ((IEnumerable<DataRow>) dataTable2.Select("SKU='" + str + "'")).CopyToDataTable<DataRow>();
        dataTable4.DefaultView.Sort = "a asc";
        dataTable3 = dataTable4.DefaultView.ToTable();
        num1 = 0;
        int int32 = Convert.ToInt32(dataTable3.Rows[0]["f"]);
        foreach (DataRow row1 in (InternalDataCollectionBase) dataTable3.Rows)
        {
          if (int32 != 0)
          {
            int num3 = 1;
            DataRow row2 = table.NewRow();
            row2["ID"] = (object) num2;
            row2["LOCATION_SKU_SIZE"] = (object) row1["LOCATION_SKU_SIZE"].ToString();
            row2["g"] = (object) num3;
            table.Rows.Add(row2);
            int32 -= num3;
            ++num2;
          }
          else
            break;
        }
      }
    }

    private static void regional_push_woh(DataSet _DataSet, string _TargetDataTableName)
    {
      DataTable table = _DataSet.Tables[_TargetDataTableName];
      DataTable dataTable1 = new DataTable();
      DataTable dataTable2 = ((IEnumerable<DataRow>) table.Select("a>0 and c>0 and f>0")).CopyToDataTable<DataRow>();
      table.Rows.Clear();
      dataTable2.Columns.Add(new DataColumn("SKU", typeof (string)));
      dataTable2.Columns.Add(new DataColumn("POH", typeof (int)));
      dataTable2.Columns.Add(new DataColumn("WOH", typeof (double)));
      foreach (DataRow row in (InternalDataCollectionBase) dataTable2.Rows)
      {
        string str = row["LOCATION_SKU_SIZE"].ToString();
        int startIndex = str.IndexOf("_", 0, str.Length) + 1;
        int length = str.Length;
        if (startIndex <= 0)
          row["a"] = (object) -1;
        else
          row["SKU"] = (object) str.ToString().Substring(startIndex, length - startIndex);
        row["POH"] = (object) Convert.ToInt32(row["e"]);
        if (Convert.ToDouble(row["d"]) == 0.0 && Convert.ToInt32(row["POH"]) > 0)
        {
          row["WOH"] = (object) 99999;
        }
        else
        {
          int num = Convert.ToDouble(row["d"]) != 0.0 ? 0 : (Convert.ToInt32(row["POH"]) == 0 ? 1 : 0);
          row["WOH"] = num == 0 ? (object) ((double) Convert.ToInt32(row["POH"]) / Convert.ToDouble(row["d"])) : (object) 0;
        }
      }
      DataTable dataTable3 = dataTable2.Clone();
      int num1 = 0;
      int num2 = 0;
      foreach (string str in dataTable2.AsEnumerable().Select<DataRow, string>((System.Func<DataRow, string>) (SKU => SKU[nameof (SKU)].ToString())).Distinct<string>().ToList<string>())
      {
        dataTable3.Rows.Clear();
        DataTable dataTable4 = ((IEnumerable<DataRow>) dataTable2.Select("SKU='" + str + "'")).CopyToDataTable<DataRow>();
        num1 = 0;
        int int32 = Convert.ToInt32(dataTable4.Rows[0]["f"]);
        dataTable4.DefaultView.Sort = "WOH asc, a asc";
        dataTable3 = dataTable4.DefaultView.ToTable();
        foreach (DataRow row1 in (InternalDataCollectionBase) dataTable3.Rows)
        {
          if (int32 != 0)
          {
            int num3 = 1;
            DataRow row2 = table.NewRow();
            row2["ID"] = (object) num2;
            row2["LOCATION_SKU_SIZE"] = (object) row1["LOCATION_SKU_SIZE"].ToString();
            row2["g"] = (object) num3;
            table.Rows.Add(row2);
            int32 -= num3;
            ++num2;
          }
          else
            break;
        }
      }
    }

    private static void regional_rebalance_gdo(DataSet _DataSet, string _TargetDataTableName)
    {
      DataTable table1 = _DataSet.Tables[_TargetDataTableName];
      DataTable dataTable1 = new DataTable();
      DataTable dataTable2 = ((IEnumerable<DataRow>) table1.Select("(c<>0 or d<>0) and f>0")).CopyToDataTable<DataRow>();
      table1.Rows.Clear();
      dataTable2.Columns.Add(new DataColumn("SKU", typeof (string)));
      dataTable2.Columns.Add(new DataColumn("POH", typeof (int)));
      dataTable2.Columns.Add(new DataColumn("SKU_GEO"));
      dataTable2.Columns.Add(new DataColumn("NEED", typeof (int)));
      dataTable2.Columns.Add(new DataColumn("GDO", typeof (float)));
      foreach (DataRow row in (InternalDataCollectionBase) dataTable2.Rows)
      {
        string str = row["LOCATION_SKU_SIZE"].ToString();
        int startIndex = str.IndexOf("_", 0, str.Length) + 1;
        int length = str.Length;
        if (startIndex <= 0)
          row["f"] = (object) -1;
        else
          row["SKU"] = (object) str.ToString().Substring(startIndex, length - startIndex);
        row["SKU_GEO"] = (object) Convert.ToString(row["SKU"]?.ToString() + "_" + Convert.ToString(row["b"]));
        row["GDO"] = (object) Convert.ToDouble(row["a"]);
        row["NEED"] = Convert.ToInt32(row["c"]) <= 0 ? (object) Convert.ToInt32(row["d"]) : (object) Convert.ToInt32(row["c"]);
      }
      dataTable2.Columns.Remove("SKU");
      dataTable2.Clone();
      dataTable2.Clone();
      DataTable dataTable3 = dataTable2.Clone();
      DataTable dataTable4 = dataTable2.Clone();
      int num1 = 0;
      DataTable dataTable5 = ((IEnumerable<DataRow>) dataTable2.Select("NEED>0")).CopyToDataTable<DataRow>();
      DataTable dataTable6 = ((IEnumerable<DataRow>) dataTable2.Select("NEED<0")).CopyToDataTable<DataRow>();
      foreach (object obj in dataTable5.AsEnumerable().Select<DataRow, string>((System.Func<DataRow, string>) (SKU_GEO => SKU_GEO[nameof (SKU_GEO)].ToString())).Distinct<string>().ToList<string>())
      {
        string str1 = obj.ToString();
        dataTable3.Rows.Clear();
        dataTable4.Rows.Clear();
        if (((IEnumerable<DataRow>) dataTable5.Select("SKU_GEO='" + str1 + "'")).Count<DataRow>() > 0)
          dataTable3 = ((IEnumerable<DataRow>) dataTable5.Select("SKU_GEO='" + str1 + "'")).CopyToDataTable<DataRow>();
        if (((IEnumerable<DataRow>) dataTable6.Select("SKU_GEO='" + str1 + "'")).Count<DataRow>() > 0)
          dataTable4 = ((IEnumerable<DataRow>) dataTable6.Select("SKU_GEO='" + str1 + "'")).CopyToDataTable<DataRow>();
        DataTable table2 = dataTable3.DefaultView.ToTable();
        table2.DefaultView.Sort = "SKU_GEO asc, GDO desc, f asc";
        dataTable3 = table2.DefaultView.ToTable();
        DataTable table3 = dataTable4.DefaultView.ToTable();
        table3.DefaultView.Sort = "SKU_GEO asc, e asc, GDO asc, f desc";
        dataTable4 = table3.DefaultView.ToTable();
        if (dataTable3.Rows.Count > 0)
        {
          foreach (DataRow row1 in (InternalDataCollectionBase) dataTable3.Rows)
          {
            if (dataTable4.Rows.Count > 0)
            {
              foreach (DataRow row2 in (InternalDataCollectionBase) dataTable4.Rows)
              {
                if (row1["SKU_GEO"].ToString() == row2["SKU_GEO"].ToString() && Convert.ToInt32(row1["NEED"]) > 0 && Convert.ToInt32(row2["NEED"]) < 0)
                {
                  int num2 = Math.Min(Convert.ToInt32(row1["NEED"]), Convert.ToInt32(row2["NEED"]) * -1);
                  if (num2 > 0)
                  {
                    row2.BeginEdit();
                    row1.BeginEdit();
                    row1["NEED"] = (object) (Convert.ToInt32(row1["NEED"]) - num2);
                    row2["NEED"] = (object) (Convert.ToInt32(row2["NEED"]) + num2);
                    row2.EndEdit();
                    row1.EndEdit();
                    ++num1;
                    DataRow row3 = table1.NewRow();
                    row3.BeginEdit();
                    string str2 = row2["LOCATION_SKU_SIZE"].ToString();
                    int num3 = str2.IndexOf("_", 0, str2.Length) + 1;
                    int length = str2.Length;
                    row3["ID"] = (object) num1;
                    row3["LOCATION_SKU_SIZE"] = row1["LOCATION_SKU_SIZE"];
                    row3["I_LOCATION"] = (object) str2.ToString().Substring(0, num3 - 1);
                    row3["g"] = (object) num2;
                    row3["h"] = (object) 0;
                    table1.Rows.Add(row3);
                    row3.EndEdit();
                    ++num1;
                    DataRow row4 = table1.NewRow();
                    row4.BeginEdit();
                    string str3 = row1["LOCATION_SKU_SIZE"].ToString();
                    int num4 = str3.IndexOf("_", 0, str3.Length) + 1;
                    length = str3.Length;
                    row4["ID"] = (object) num1;
                    row4["LOCATION_SKU_SIZE"] = row2["LOCATION_SKU_SIZE"];
                    row4["I_LOCATION"] = (object) str3.ToString().Substring(0, num4 - 1);
                    row4["g"] = (object) 0;
                    row4["h"] = (object) -num2;
                    table1.Rows.Add(row4);
                    row4.EndEdit();
                  }
                }
              }
            }
          }
        }
      }
    }

    private static void regional_rebalance_oh(DataSet _DataSet, string _TargetDataTableName)
    {
      DataTable table1 = _DataSet.Tables[_TargetDataTableName];
      DataTable dataTable1 = new DataTable();
      DataTable dataTable2 = ((IEnumerable<DataRow>) table1.Select("(c<>0 and f=0) or d<>0")).CopyToDataTable<DataRow>();
      table1.Rows.Clear();
      dataTable2.Columns.Add(new DataColumn("SKU", typeof (string)));
      dataTable2.Columns.Add(new DataColumn("SKU_GEO"));
      dataTable2.Columns.Add(new DataColumn("NEED", typeof (int)));
      dataTable2.Columns.Add(new DataColumn("OH", typeof (int)));
      foreach (DataRow row in (InternalDataCollectionBase) dataTable2.Rows)
      {
        string str = row["LOCATION_SKU_SIZE"].ToString();
        int startIndex = str.IndexOf("_", 0, str.Length) + 1;
        int length = str.Length;
        if (startIndex <= 0)
          row["h"] = (object) -1;
        else
          row["SKU"] = (object) str.ToString().Substring(startIndex, length - startIndex);
        row["SKU_GEO"] = (object) Convert.ToString(row["SKU"]?.ToString() + "_" + Convert.ToString(row["b"]));
        row["NEED"] = Convert.ToInt32(row["c"]) <= 0 ? (object) Convert.ToInt32(row["d"]) : (object) 1;
      }
      dataTable2.Columns.Remove("SKU");
      dataTable2.Clone();
      dataTable2.Clone();
      DataTable dataTable3 = dataTable2.Clone();
      DataTable dataTable4 = dataTable2.Clone();
      int num1 = 0;
      int num2 = 0;
      DataTable dataTable5 = ((IEnumerable<DataRow>) dataTable2.Select("NEED>0 and h>0 and f=0")).CopyToDataTable<DataRow>();
      DataTable dataTable6 = ((IEnumerable<DataRow>) dataTable2.Select("NEED<0 and h>0")).CopyToDataTable<DataRow>();
      List<string> list1 = dataTable5.AsEnumerable().Select<DataRow, string>((System.Func<DataRow, string>) (SKU_GEO => SKU_GEO[nameof (SKU_GEO)].ToString())).Distinct<string>().ToList<string>();
      List<string> list2 = dataTable6.AsEnumerable().Select<DataRow, string>((System.Func<DataRow, string>) (SKU_GEO => SKU_GEO[nameof (SKU_GEO)].ToString())).Distinct<string>().ToList<string>();
      List<string> source = new List<string>();
      foreach (string str1 in list1)
      {
        foreach (string str2 in list2)
        {
          if (str1 == str2)
            source.Add(str1);
        }
      }
      foreach (object obj in source.Distinct<string>().ToList<string>())
      {
        string str3 = obj.ToString();
        int num3 = 0;
        int num4 = 0;
        dataTable3.Rows.Clear();
        dataTable4.Rows.Clear();
        if (((IEnumerable<DataRow>) dataTable5.Select("SKU_GEO='" + str3 + "'")).Count<DataRow>() > 0)
          dataTable3 = ((IEnumerable<DataRow>) dataTable5.Select("SKU_GEO='" + str3 + "'")).CopyToDataTable<DataRow>();
        if (((IEnumerable<DataRow>) dataTable6.Select("SKU_GEO='" + str3 + "'")).Count<DataRow>() > 0)
          dataTable4 = ((IEnumerable<DataRow>) dataTable6.Select("SKU_GEO='" + str3 + "'")).CopyToDataTable<DataRow>();
        DataTable table2 = dataTable3.DefaultView.ToTable();
        table2.DefaultView.Sort = "h asc";
        dataTable3 = table2.DefaultView.ToTable();
        DataTable table3 = dataTable4.DefaultView.ToTable();
        table3.DefaultView.Sort = "g asc, a asc, h desc";
        dataTable4 = table3.DefaultView.ToTable();
        foreach (DataRow row in (InternalDataCollectionBase) dataTable3.Rows)
          num3 += Convert.ToInt32(row["NEED"]);
        foreach (DataRow row in (InternalDataCollectionBase) dataTable4.Rows)
          num4 += Convert.ToInt32(row["NEED"]);
        foreach (DataRow row1 in (InternalDataCollectionBase) dataTable3.Rows)
        {
          foreach (DataRow row2 in (InternalDataCollectionBase) dataTable4.Rows)
          {
            if (row1["SKU_GEO"].ToString() == row2["SKU_GEO"].ToString())
            {
              num1 = 0;
              int num5 = Math.Min(Math.Min(Convert.ToInt32(row1["NEED"]), Convert.ToInt32(row2["NEED"]) * -1), 1);
              if (num5 > 0)
              {
                ++num2;
                DataRow row3 = table1.NewRow();
                row3.BeginEdit();
                string str4 = row2["LOCATION_SKU_SIZE"].ToString();
                int num6 = str4.IndexOf("_", 0, str4.Length) + 1;
                int length = str4.Length;
                row3["ID"] = (object) num2;
                row3["LOCATION_SKU_SIZE"] = row1["LOCATION_SKU_SIZE"];
                row3["I_LOCATION"] = (object) str4.ToString().Substring(0, num6 - 1);
                row3["i"] = (object) 1;
                row3["j"] = (object) 0;
                table1.Rows.Add(row3);
                row3.EndEdit();
                ++num2;
                DataRow row4 = table1.NewRow();
                row4.BeginEdit();
                string str5 = row1["LOCATION_SKU_SIZE"].ToString();
                int num7 = str5.IndexOf("_", 0, str5.Length) + 1;
                length = str5.Length;
                row4["ID"] = (object) num2;
                row4["LOCATION_SKU_SIZE"] = row2["LOCATION_SKU_SIZE"];
                row4["I_LOCATION"] = (object) str5.ToString().Substring(0, num7 - 1);
                row4["i"] = (object) 0;
                row4["j"] = (object) -1;
                table1.Rows.Add(row4);
                row4.EndEdit();
                row2.BeginEdit();
                row1.BeginEdit();
                row1["NEED"] = (object) (Convert.ToInt32(row1["NEED"]) - 1);
                row2["NEED"] = (object) (Convert.ToInt32(row2["NEED"]) + 1);
                row2.EndEdit();
                row1.EndEdit();
                dataTable3 = dataTable3.DefaultView.ToTable();
                dataTable3.DefaultView.Sort = "h asc";
                dataTable3 = dataTable3.DefaultView.ToTable();
                dataTable4 = dataTable4.DefaultView.ToTable();
                dataTable4.DefaultView.Sort = "g asc, a asc, h desc";
                dataTable4 = dataTable4.DefaultView.ToTable();
                num3 -= num5;
                num4 += num5;
              }
            }
          }
        }
      }
    }

    private static void regional_rebalance_woh(DataSet _DataSet, string _TargetDataTableName)
    {
      DataTable table1 = _DataSet.Tables[_TargetDataTableName];
      DataTable dataTable1 = new DataTable();
      DataTable dataTable2 = ((IEnumerable<DataRow>) table1.Select("(c<>0 or d<>0) and h>0")).CopyToDataTable<DataRow>();
      table1.Rows.Clear();
      dataTable2.Columns.Add(new DataColumn("SKU", typeof (string)));
      dataTable2.Columns.Add(new DataColumn("SKU_GEO"));
      dataTable2.Columns.Add(new DataColumn("NEED", typeof (int)));
      dataTable2.Columns.Add(new DataColumn("POH", typeof (int)));
      dataTable2.Columns.Add(new DataColumn("WOH", typeof (float)));
      dataTable2.Columns.Add(new DataColumn("GDO", typeof (float)));
      foreach (DataRow row in (InternalDataCollectionBase) dataTable2.Rows)
      {
        string str = row["LOCATION_SKU_SIZE"].ToString();
        int startIndex = str.IndexOf("_", 0, str.Length) + 1;
        int length = str.Length;
        if (startIndex <= 0)
          row["h"] = (object) -1;
        else
          row["SKU"] = (object) str.ToString().Substring(startIndex, length - startIndex);
        row["SKU_GEO"] = (object) Convert.ToString(row["SKU"]?.ToString() + "_" + Convert.ToString(row["b"]));
        row["POH"] = (object) Convert.ToInt32(row["e"]);
        row["GDO"] = (object) Convert.ToDouble(row["a"]);
        if (Convert.ToDouble(row["GDO"]) == 0.0 && Convert.ToInt32(row["POH"]) > 0)
        {
          row["WOH"] = (object) 9999;
        }
        else
        {
          int num = Convert.ToDouble(row["GDO"]) != 0.0 ? 0 : (Convert.ToInt32(row["POH"]) == 0 ? 1 : 0);
          row["WOH"] = num == 0 ? (object) (Convert.ToDouble(row["POH"]) / Convert.ToDouble(row["GDO"])) : (object) 0;
        }
        row["NEED"] = Convert.ToInt32(row["c"]) <= 0 ? (object) Convert.ToInt32(row["d"]) : (object) Convert.ToInt32(row["c"]);
      }
      dataTable2.Columns.Remove("SKU");
      dataTable2.Clone();
      dataTable2.Clone();
      DataTable dataTable3 = dataTable2.Clone();
      DataTable dataTable4 = dataTable2.Clone();
      int num1 = 0;
      int num2 = 0;
      DataTable dataTable5 = ((IEnumerable<DataRow>) dataTable2.Select("NEED>0 and h>0")).CopyToDataTable<DataRow>();
      DataTable dataTable6 = ((IEnumerable<DataRow>) dataTable2.Select("NEED<0 and h>0")).CopyToDataTable<DataRow>();
      List<string> list1 = dataTable5.AsEnumerable().Select<DataRow, string>((System.Func<DataRow, string>) (SKU_GEO => SKU_GEO[nameof (SKU_GEO)].ToString())).Distinct<string>().ToList<string>();
      List<string> list2 = dataTable6.AsEnumerable().Select<DataRow, string>((System.Func<DataRow, string>) (SKU_GEO => SKU_GEO[nameof (SKU_GEO)].ToString())).Distinct<string>().ToList<string>();
      List<string> source = new List<string>();
      foreach (string str1 in list1)
      {
        foreach (string str2 in list2)
        {
          if (str1 == str2)
            source.Add(str1);
        }
      }
      foreach (object obj in source.Distinct<string>().ToList<string>())
      {
        string str3 = obj.ToString();
        int num3 = 0;
        int num4 = 0;
        dataTable3.Rows.Clear();
        dataTable4.Rows.Clear();
        if (((IEnumerable<DataRow>) dataTable5.Select("SKU_GEO='" + str3 + "'")).Count<DataRow>() > 0)
          dataTable3 = ((IEnumerable<DataRow>) dataTable5.Select("SKU_GEO='" + str3 + "'")).CopyToDataTable<DataRow>();
        if (((IEnumerable<DataRow>) dataTable6.Select("SKU_GEO='" + str3 + "'")).Count<DataRow>() > 0)
          dataTable4 = ((IEnumerable<DataRow>) dataTable6.Select("SKU_GEO='" + str3 + "'")).CopyToDataTable<DataRow>();
        DataTable table2 = dataTable3.DefaultView.ToTable();
        table2.DefaultView.Sort = "WOH asc, h asc";
        dataTable3 = table2.DefaultView.ToTable();
        DataTable table3 = dataTable4.DefaultView.ToTable();
        table3.DefaultView.Sort = "g asc, WOH desc, h desc";
        dataTable4 = table3.DefaultView.ToTable();
        foreach (DataRow row in (InternalDataCollectionBase) dataTable3.Rows)
          num3 += Convert.ToInt32(row["NEED"]);
        foreach (DataRow row in (InternalDataCollectionBase) dataTable4.Rows)
          num4 += Convert.ToInt32(row["NEED"]);
        foreach (DataRow row1 in (InternalDataCollectionBase) dataTable3.Rows)
        {
          foreach (DataRow row2 in (InternalDataCollectionBase) dataTable4.Rows)
          {
            if (row1["SKU_GEO"].ToString() == row2["SKU_GEO"].ToString())
            {
              num1 = 0;
              int num5 = Math.Min(Convert.ToInt32(row1["NEED"]), Convert.ToInt32(row2["NEED"]) * -1);
              if (num5 > 0)
              {
                ++num2;
                DataRow row3 = table1.NewRow();
                row3.BeginEdit();
                string str4 = row2["LOCATION_SKU_SIZE"].ToString();
                int num6 = str4.IndexOf("_", 0, str4.Length) + 1;
                int length = str4.Length;
                row3["ID"] = (object) num2;
                row3["LOCATION_SKU_SIZE"] = row1["LOCATION_SKU_SIZE"];
                row3["I_LOCATION"] = (object) str4.ToString().Substring(0, num6 - 1);
                row3["i"] = (object) num5;
                row3["j"] = (object) 0;
                table1.Rows.Add(row3);
                row3.EndEdit();
                ++num2;
                DataRow row4 = table1.NewRow();
                row4.BeginEdit();
                string str5 = row1["LOCATION_SKU_SIZE"].ToString();
                int num7 = str5.IndexOf("_", 0, str5.Length) + 1;
                length = str5.Length;
                row4["ID"] = (object) num2;
                row4["LOCATION_SKU_SIZE"] = row2["LOCATION_SKU_SIZE"];
                row4["I_LOCATION"] = (object) str5.ToString().Substring(0, num7 - 1);
                row4["i"] = (object) 0;
                row4["j"] = (object) -num5;
                table1.Rows.Add(row4);
                row4.EndEdit();
                row2.BeginEdit();
                row1.BeginEdit();
                row1["NEED"] = (object) (Convert.ToInt32(row1["NEED"]) - num5);
                row2["NEED"] = (object) (Convert.ToInt32(row2["NEED"]) + num5);
                row1["POH"] = (object) (Convert.ToInt32(row1["POH"]) + num5);
                row2["POH"] = (object) (Convert.ToInt32(row2["POH"]) - num5);
                if (Convert.ToDouble(row2["GDO"]) == 0.0 && Convert.ToInt32(row2["POH"]) > 0)
                {
                  row2["WOH"] = (object) 9999;
                }
                else
                {
                  int num8 = Convert.ToDouble(row2["GDO"]) != 0.0 ? 0 : (Convert.ToInt32(row2["POH"]) == 0 ? 1 : 0);
                  row2["WOH"] = num8 == 0 ? (object) ((double) Convert.ToInt32(row2["POH"]) / Convert.ToDouble(row2["GDO"])) : (object) 0;
                }
                if (Convert.ToDouble(row1["GDO"]) == 0.0 && Convert.ToInt32(row1["POH"]) > 0)
                {
                  row1["WOH"] = (object) 9999;
                }
                else
                {
                  int num9 = Convert.ToDouble(row1["GDO"]) != 0.0 ? 0 : (Convert.ToInt32(row1["POH"]) == 0 ? 1 : 0);
                  row1["WOH"] = num9 == 0 ? (object) ((double) Convert.ToInt32(row1["POH"]) / Convert.ToDouble(row1["GDO"])) : (object) 0;
                }
                row2.EndEdit();
                row1.EndEdit();
                num3 -= num5;
                num4 += num5;
              }
            }
          }
        }
      }
    }

    private static void regional_rebalance_gdo_woh(DataSet _DataSet, string _TargetDataTableName)
    {
      DataTable table1 = _DataSet.Tables[_TargetDataTableName];
      DataTable dataTable1 = new DataTable();
      DataTable dataTable2 = ((IEnumerable<DataRow>) table1.Select("(c<>0 or d<>0) and h>0")).CopyToDataTable<DataRow>();
      table1.Rows.Clear();
      dataTable2.Columns.Add(new DataColumn("SKU", typeof (string)));
      dataTable2.Columns.Add(new DataColumn("SKU_GEO"));
      dataTable2.Columns.Add(new DataColumn("NEED", typeof (int)));
      dataTable2.Columns.Add(new DataColumn("POH", typeof (int)));
      dataTable2.Columns.Add(new DataColumn("WOH", typeof (float)));
      dataTable2.Columns.Add(new DataColumn("GDO", typeof (float)));
      foreach (DataRow row in (InternalDataCollectionBase) dataTable2.Rows)
      {
        string str = row["LOCATION_SKU_SIZE"].ToString();
        int startIndex = str.IndexOf("_", 0, str.Length) + 1;
        int length = str.Length;
        if (startIndex <= 0)
          row["h"] = (object) -1;
        else
          row["SKU"] = (object) str.ToString().Substring(startIndex, length - startIndex);
        row["SKU_GEO"] = (object) Convert.ToString(row["SKU"]?.ToString() + "_" + Convert.ToString(row["b"]));
        row["POH"] = (object) Convert.ToInt32(row["e"]);
        row["GDO"] = (object) Convert.ToDouble(row["a"]);
        if (Convert.ToDouble(row["GDO"]) != 0.0)
          row["WOH"] = (object) ((double) Convert.ToInt32(row["POH"]) / Convert.ToDouble(row["a"]));
        if (Convert.ToDouble(row["GDO"]) == 0.0 && Convert.ToInt32(row["POH"]) != 0)
          row["WOH"] = (object) 9999;
        if (Convert.ToDouble(row["GDO"]) == 0.0 && Convert.ToInt32(row["POH"]) == 0)
          row["WOH"] = (object) 0;
        row["NEED"] = Convert.ToInt32(row["c"]) <= 0 ? (object) Convert.ToInt32(row["d"]) : (object) Convert.ToInt32(row["c"]);
      }
      dataTable2.Columns.Remove("SKU");
      dataTable2.Clone();
      dataTable2.Clone();
      DataTable dataTable3 = dataTable2.Clone();
      DataTable dataTable4 = dataTable2.Clone();
      int num1 = 0;
      int num2 = 0;
      DataTable dataTable5 = ((IEnumerable<DataRow>) dataTable2.Select("NEED>0")).CopyToDataTable<DataRow>();
      DataTable dataTable6 = ((IEnumerable<DataRow>) dataTable2.Select("NEED<0")).CopyToDataTable<DataRow>();
      List<string> list1 = dataTable5.AsEnumerable().Select<DataRow, string>((System.Func<DataRow, string>) (SKU_GEO => SKU_GEO[nameof (SKU_GEO)].ToString())).Distinct<string>().ToList<string>();
      List<string> list2 = dataTable6.AsEnumerable().Select<DataRow, string>((System.Func<DataRow, string>) (SKU_GEO => SKU_GEO[nameof (SKU_GEO)].ToString())).Distinct<string>().ToList<string>();
      List<string> source = new List<string>();
      foreach (string str1 in list1)
      {
        foreach (string str2 in list2)
        {
          if (str1 == str2)
            source.Add(str1);
        }
      }
      foreach (object obj in source.Distinct<string>().ToList<string>())
      {
        string str3 = obj.ToString();
        int num3 = 0;
        int num4 = 0;
        dataTable3.Rows.Clear();
        dataTable4.Rows.Clear();
        if (((IEnumerable<DataRow>) dataTable5.Select("SKU_GEO='" + str3 + "'")).Count<DataRow>() > 0)
          dataTable3 = ((IEnumerable<DataRow>) dataTable5.Select("SKU_GEO='" + str3 + "'")).CopyToDataTable<DataRow>();
        if (((IEnumerable<DataRow>) dataTable6.Select("SKU_GEO='" + str3 + "'")).Count<DataRow>() > 0)
          dataTable4 = ((IEnumerable<DataRow>) dataTable6.Select("SKU_GEO='" + str3 + "'")).CopyToDataTable<DataRow>();
        DataTable table2 = dataTable3.DefaultView.ToTable();
        table2.DefaultView.Sort = "SKU_GEO asc, GDO desc, WOH asc, h asc";
        dataTable3 = table2.DefaultView.ToTable();
        DataTable table3 = dataTable4.DefaultView.ToTable();
        table3.DefaultView.Sort = "SKU_GEO asc, g asc, GDO asc, WOH desc, h desc";
        dataTable4 = table3.DefaultView.ToTable();
        foreach (DataRow row in (InternalDataCollectionBase) dataTable3.Rows)
          num3 += Convert.ToInt32(row["NEED"]);
        foreach (DataRow row in (InternalDataCollectionBase) dataTable4.Rows)
          num4 += Convert.ToInt32(row["NEED"]);
        while (num3 > 0 && num4 < 0)
        {
          DataRow row1 = dataTable3.Rows[0];
          int num5 = 0;
          foreach (DataRow row2 in (InternalDataCollectionBase) dataTable4.Rows)
          {
            if (num5 == 0 && row1["SKU_GEO"].ToString() == row2["SKU_GEO"].ToString())
            {
              num1 = 0;
              int num6 = Math.Min(Math.Min(Convert.ToInt32(row1["NEED"]), Convert.ToInt32(row2["NEED"]) * -1), 1);
              if (num6 > 0)
              {
                ++num2;
                DataRow row3 = table1.NewRow();
                row3.BeginEdit();
                string str4 = row2["LOCATION_SKU_SIZE"].ToString();
                int num7 = str4.IndexOf("_", 0, str4.Length) + 1;
                int length = str4.Length;
                row3["ID"] = (object) num2;
                row3["LOCATION_SKU_SIZE"] = row1["LOCATION_SKU_SIZE"];
                row3["I_LOCATION"] = (object) str4.ToString().Substring(0, num7 - 1);
                row3["i"] = (object) 1;
                row3["j"] = (object) 0;
                table1.Rows.Add(row3);
                row3.EndEdit();
                ++num2;
                DataRow row4 = table1.NewRow();
                row4.BeginEdit();
                string str5 = row1["LOCATION_SKU_SIZE"].ToString();
                int num8 = str5.IndexOf("_", 0, str5.Length) + 1;
                length = str5.Length;
                row4["ID"] = (object) num2;
                row4["LOCATION_SKU_SIZE"] = row2["LOCATION_SKU_SIZE"];
                row4["I_LOCATION"] = (object) str5.ToString().Substring(0, num8 - 1);
                row4["i"] = (object) 0;
                row4["j"] = (object) -1;
                table1.Rows.Add(row4);
                row4.EndEdit();
                row2.BeginEdit();
                row1.BeginEdit();
                row1["NEED"] = (object) (Convert.ToInt32(row1["NEED"]) - 1);
                row2["NEED"] = (object) (Convert.ToInt32(row2["NEED"]) + 1);
                row1["POH"] = (object) (Convert.ToInt32(row1["POH"]) + 1);
                row2["POH"] = (object) (Convert.ToInt32(row2["POH"]) - 1);
                if (Convert.ToDouble(row1["GDO"]) != 0.0)
                  row1["WOH"] = (object) ((double) Convert.ToInt32(row1["POH"]) / Convert.ToDouble(row1["a"]));
                if (Convert.ToDouble(row1["GDO"]) == 0.0 && Convert.ToInt32(row1["POH"]) != 0)
                  row1["WOH"] = (object) 9999;
                if (Convert.ToDouble(row1["GDO"]) == 0.0 && Convert.ToInt32(row1["POH"]) == 0)
                  row1["WOH"] = (object) 0;
                if (Convert.ToDouble(row2["GDO"]) != 0.0)
                  row2["WOH"] = (object) ((double) Convert.ToInt32(row2["POH"]) / Convert.ToDouble(row2["a"]));
                if (Convert.ToDouble(row2["GDO"]) == 0.0 && Convert.ToInt32(row2["POH"]) != 0)
                  row2["WOH"] = (object) 9999;
                if (Convert.ToDouble(row2["GDO"]) == 0.0 && Convert.ToInt32(row2["POH"]) == 0)
                  row2["WOH"] = (object) 0;
                row2.EndEdit();
                row1.EndEdit();
                foreach (DataRow row5 in (InternalDataCollectionBase) dataTable3.Rows)
                {
                  if (Convert.ToInt32(row5["NEED"]) == 0)
                  {
                    row5["GDO"] = (object) -999999;
                    row5["WOH"] = (object) 999999;
                  }
                }
                foreach (DataRow row6 in (InternalDataCollectionBase) dataTable4.Rows)
                {
                  if (Convert.ToInt32(row6["NEED"]) == 0)
                  {
                    row6["GDO"] = (object) 999999;
                    row6["WOH"] = (object) -999999;
                  }
                }
                dataTable3 = dataTable3.DefaultView.ToTable();
                dataTable3.DefaultView.Sort = "SKU_GEO asc, GDO desc, WOH asc, h asc";
                dataTable3 = dataTable3.DefaultView.ToTable();
                dataTable4 = dataTable4.DefaultView.ToTable();
                dataTable4.DefaultView.Sort = "SKU_GEO asc, g asc, GDO asc, WOH desc, h desc";
                dataTable4 = dataTable4.DefaultView.ToTable();
                num3 -= num6;
                num4 += num6;
                num5 = 1;
              }
            }
          }
        }
      }
    }

    private static void regional_rebalance_gdo_new_opening(
      DataSet _DataSet,
      string _TargetDataTableName)
    {
      DataTable table1 = _DataSet.Tables[_TargetDataTableName];
      DataTable dataTable1 = new DataTable();
      DataTable dataTable2 = ((IEnumerable<DataRow>) table1.Select("(c<>0 or d<>0) and f>0")).CopyToDataTable<DataRow>();
      table1.Rows.Clear();
      dataTable2.Columns.Add(new DataColumn("SKU", typeof (string)));
      dataTable2.Columns.Add(new DataColumn("POH", typeof (int)));
      dataTable2.Columns.Add(new DataColumn("SKU_GEO"));
      dataTable2.Columns.Add(new DataColumn("NEED", typeof (int)));
      dataTable2.Columns.Add(new DataColumn("GDO", typeof (float)));
      foreach (DataRow row in (InternalDataCollectionBase) dataTable2.Rows)
      {
        string str = row["LOCATION_SKU_SIZE"].ToString();
        int startIndex = str.IndexOf("_", 0, str.Length) + 1;
        int length = str.Length;
        if (startIndex <= 0)
          row["f"] = (object) -1;
        else
          row["SKU"] = (object) str.ToString().Substring(startIndex, length - startIndex);
        row["SKU_GEO"] = (object) Convert.ToString(row["SKU"]?.ToString() + "_" + Convert.ToString(row["b"]));
        row["GDO"] = (object) Convert.ToDouble(row["a"]);
        row["NEED"] = Convert.ToInt32(row["c"]) <= 0 ? (object) Convert.ToInt32(row["d"]) : (object) Convert.ToInt32(row["c"]);
      }
      dataTable2.Columns.Remove("SKU");
      dataTable2.Clone();
      dataTable2.Clone();
      DataTable dataTable3 = dataTable2.Clone();
      DataTable dataTable4 = dataTable2.Clone();
      int num1 = 0;
      DataTable dataTable5 = ((IEnumerable<DataRow>) dataTable2.Select("NEED>0")).CopyToDataTable<DataRow>();
      DataTable dataTable6 = ((IEnumerable<DataRow>) dataTable2.Select("NEED<0")).CopyToDataTable<DataRow>();
      foreach (object obj in dataTable5.AsEnumerable().Select<DataRow, string>((System.Func<DataRow, string>) (SKU_GEO => SKU_GEO[nameof (SKU_GEO)].ToString())).Distinct<string>().ToList<string>())
      {
        string str1 = obj.ToString();
        dataTable3.Rows.Clear();
        dataTable4.Rows.Clear();
        if (((IEnumerable<DataRow>) dataTable5.Select("SKU_GEO='" + str1 + "'")).Count<DataRow>() > 0)
          dataTable3 = ((IEnumerable<DataRow>) dataTable5.Select("SKU_GEO='" + str1 + "'")).CopyToDataTable<DataRow>();
        if (((IEnumerable<DataRow>) dataTable6.Select("SKU_GEO='" + str1 + "'")).Count<DataRow>() > 0)
          dataTable4 = ((IEnumerable<DataRow>) dataTable6.Select("SKU_GEO='" + str1 + "'")).CopyToDataTable<DataRow>();
        DataTable table2 = dataTable3.DefaultView.ToTable();
        table2.DefaultView.Sort = "SKU_GEO asc, GDO desc, f asc";
        dataTable3 = table2.DefaultView.ToTable();
        DataTable table3 = dataTable4.DefaultView.ToTable();
        table3.DefaultView.Sort = "SKU_GEO asc, e asc, GDO asc, f desc";
        dataTable4 = table3.DefaultView.ToTable();
        if (dataTable3.Rows.Count > 0)
        {
          foreach (DataRow row1 in (InternalDataCollectionBase) dataTable3.Rows)
          {
            if (dataTable4.Rows.Count > 0)
            {
              foreach (DataRow row2 in (InternalDataCollectionBase) dataTable4.Rows)
              {
                if (row1["SKU_GEO"].ToString() == row2["SKU_GEO"].ToString() && Convert.ToInt32(row1["NEED"]) > 0 && Convert.ToInt32(row2["NEED"]) < 0)
                {
                  int num2 = 0;
                  num2 = Convert.ToInt32(row1["NEED"]);
                  int num3 = Math.Min(1, Convert.ToInt32(row2["NEED"]) * -1);
                  if (num3 > 0)
                  {
                    row2.BeginEdit();
                    row1.BeginEdit();
                    row1["NEED"] = (object) (Convert.ToInt32(row1["NEED"]) - num3);
                    row2["NEED"] = (object) (Convert.ToInt32(row2["NEED"]) + num3);
                    row2.EndEdit();
                    row1.EndEdit();
                    ++num1;
                    DataRow row3 = table1.NewRow();
                    row3.BeginEdit();
                    string str2 = row2["LOCATION_SKU_SIZE"].ToString();
                    int num4 = str2.IndexOf("_", 0, str2.Length) + 1;
                    int length = str2.Length;
                    row3["ID"] = (object) num1;
                    row3["LOCATION_SKU_SIZE"] = row1["LOCATION_SKU_SIZE"];
                    row3["I_LOCATION"] = (object) str2.ToString().Substring(0, num4 - 1);
                    row3["g"] = (object) num3;
                    row3["h"] = (object) 0;
                    table1.Rows.Add(row3);
                    row3.EndEdit();
                    ++num1;
                    DataRow row4 = table1.NewRow();
                    row4.BeginEdit();
                    string str3 = row1["LOCATION_SKU_SIZE"].ToString();
                    int num5 = str3.IndexOf("_", 0, str3.Length) + 1;
                    length = str3.Length;
                    row4["ID"] = (object) num1;
                    row4["LOCATION_SKU_SIZE"] = row2["LOCATION_SKU_SIZE"];
                    row4["I_LOCATION"] = (object) str3.ToString().Substring(0, num5 - 1);
                    row4["g"] = (object) 0;
                    row4["h"] = (object) -num3;
                    table1.Rows.Add(row4);
                    row4.EndEdit();
                  }
                }
              }
            }
          }
        }
      }
    }

    private static void central_initial_allocation_fixed(
      DataSet _DataSet,
      string _TargetDataTableName)
    {
      DataTable table = _DataSet.Tables[_TargetDataTableName];
      DataTable dataTable1 = new DataTable();
      DataTable dataTable2 = ((IEnumerable<DataRow>) table.Select("a>0 and d>0 and e>0")).CopyToDataTable<DataRow>();
      table.Rows.Clear();
      dataTable2.Columns.Add("SKU");
      foreach (DataRow row in (InternalDataCollectionBase) dataTable2.Rows)
      {
        string str = row["REGIONAL_WH_SKU_SIZE"].ToString();
        int startIndex = str.IndexOf("_", 0, str.Length) + 1;
        int length = str.Length;
        if (startIndex <= 0)
          row["a"] = (object) -1;
        else
          row["SKU"] = (object) str.ToString().Substring(startIndex, length - startIndex);
      }
      DataTable dataTable3 = new DataTable();
      int num1 = 0;
      int num2 = 0;
      foreach (string str in dataTable2.AsEnumerable().Select<DataRow, string>((System.Func<DataRow, string>) (SKU => SKU[nameof (SKU)].ToString())).Distinct<string>().ToList<string>())
      {
        dataTable3.Clear();
        DataTable dataTable4 = ((IEnumerable<DataRow>) dataTable2.Select("SKU = '" + str + "'")).CopyToDataTable<DataRow>();
        dataTable4.DefaultView.Sort = "a asc";
        dataTable3 = dataTable4.DefaultView.ToTable();
        int int32 = Convert.ToInt32(dataTable3.Rows[0]["e"]);
        foreach (DataRow row1 in (InternalDataCollectionBase) dataTable3.Rows)
        {
          num1 = 0;
          int num3 = Math.Min(Convert.ToInt32(row1["d"]), int32);
          if (num3 > 0)
          {
            DataRow row2 = table.NewRow();
            row2["ID"] = (object) num2;
            row2["REGIONAL_WH_SKU_SIZE"] = (object) row1["REGIONAL_WH_SKU_SIZE"].ToString();
            row2["f"] = (object) num3;
            table.Rows.Add(row2);
            ++num2;
            int32 -= num3;
          }
        }
      }
    }

    private static void central_rpl_gdo_buying_reserve(
      DataSet _DataSet,
      string _TargetDataTableName)
    {
      DataTable table = _DataSet.Tables[_TargetDataTableName];
      DataTable dataTable1 = new DataTable();
      DataTable dataTable2 = ((IEnumerable<DataRow>) table.Select("a>0 and f>0 and f>g and i>0")).CopyToDataTable<DataRow>();
      table.Rows.Clear();
      dataTable2.Columns.Add("SKU");
      dataTable2.Columns.Add("NEED");
      foreach (DataRow row in (InternalDataCollectionBase) dataTable2.Rows)
      {
        string str = row["REGIONAL_WH_SKU_SIZE"].ToString();
        int startIndex = str.IndexOf("_", 0, str.Length) + 1;
        int length = str.Length;
        if (startIndex <= 0)
          row["a"] = (object) -1;
        else
          row["SKU"] = (object) str.ToString().Substring(startIndex, length - startIndex);
        row["NEED"] = (object) (Convert.ToInt32(row["f"]) - Convert.ToInt32(row["g"]));
      }
      DataTable dataTable3 = new DataTable();
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      int num4 = 0;
      foreach (string str in dataTable2.AsEnumerable().Select<DataRow, string>((System.Func<DataRow, string>) (SKU => SKU[nameof (SKU)].ToString())).Distinct<string>().ToList<string>())
      {
        dataTable3.Clear();
        dataTable3 = ((IEnumerable<DataRow>) dataTable2.Select("SKU = '" + str + "'")).CopyToDataTable<DataRow>();
        int val2_1 = 0;
        foreach (DataRow row in (InternalDataCollectionBase) dataTable3.Rows)
          val2_1 += Convert.ToInt32(row["h"]);
        int int32 = Convert.ToInt32(Math.Min(Convert.ToInt32(dataTable3.Rows[0]["i"]), val2_1));
        int val2_2 = Convert.ToInt32(dataTable3.Rows[0]["i"]) - int32;
        int num5 = 0;
        foreach (DataRow row in (InternalDataCollectionBase) dataTable3.Rows)
          num5 += Convert.ToInt32(row["NEED"]);
        if ((int32 > 0 || val2_2 > 0) && num5 > 0 && ((IEnumerable<DataRow>) dataTable3.Select("a>0 and NEED>0")).Count<DataRow>() > 0)
        {
          DataTable dataTable4 = ((IEnumerable<DataRow>) dataTable3.Select("a>0 and NEED>0")).CopyToDataTable<DataRow>();
          dataTable4.DefaultView.Sort = "d desc, a asc";
          dataTable3 = dataTable4.DefaultView.ToTable();
          int num6 = 1;
          int num7 = 0;
          while (num6 == 1)
          {
            foreach (DataRow row1 in (InternalDataCollectionBase) dataTable3.Rows)
            {
              if ((int32 > 0 || val2_2 > 0) && num5 != 0)
              {
                if (Convert.ToInt32(row1["NEED"]) > 0)
                {
                  int val1_1 = Math.Min(Convert.ToInt32(row1["NEED"]), Convert.ToInt32(row1["h"]));
                  int val1_2 = Math.Max(Convert.ToInt32(row1["NEED"]) - val1_1, 0);
                  int num8 = 0;
                  if (val1_1 > 0 && num8 == 0)
                  {
                    num3 = 0;
                    int num9 = Math.Min(Math.Min(val1_1, int32), 1);
                    if (num9 > 0)
                    {
                      DataRow row2 = table.NewRow();
                      row2["ID"] = (object) num4;
                      row2["REGIONAL_WH_SKU_SIZE"] = (object) row1["REGIONAL_WH_SKU_SIZE"].ToString();
                      row2["j"] = (object) num9;
                      table.Rows.Add(row2);
                      ++num4;
                      num5 -= num9;
                      int32 -= num9;
                      num1 = val1_1 - num9;
                      row1.BeginEdit();
                      row1["NEED"] = (object) (Convert.ToInt32(row1["NEED"]) - num9);
                      row1["h"] = (object) (Convert.ToInt32(row1["h"]) - num9);
                      row1.EndEdit();
                      continue;
                    }
                    num3 = 0;
                    num8 = Math.Min(Math.Min(val1_1, val2_2), 1);
                    if (num8 > 0)
                    {
                      DataRow row3 = table.NewRow();
                      row3["ID"] = (object) num4;
                      row3["REGIONAL_WH_SKU_SIZE"] = (object) row1["REGIONAL_WH_SKU_SIZE"].ToString();
                      row3["j"] = (object) num8;
                      table.Rows.Add(row3);
                      ++num4;
                      num5 -= num8;
                      val2_2 -= num8;
                      num1 = val1_1 - num8;
                      row1.BeginEdit();
                      row1["NEED"] = (object) (Convert.ToInt32(row1["NEED"]) - num8);
                      row1["h"] = (object) (Convert.ToInt32(row1["h"]) - num8);
                      row1.EndEdit();
                      continue;
                    }
                  }
                  if (val1_2 > 0 && num8 == 0)
                  {
                    num3 = 0;
                    int num10 = Math.Min(Math.Min(val1_2, val2_2), 1);
                    if (num10 > 0)
                    {
                      DataRow row4 = table.NewRow();
                      row4["ID"] = (object) num4;
                      row4["REGIONAL_WH_SKU_SIZE"] = (object) row1["REGIONAL_WH_SKU_SIZE"].ToString();
                      row4["j"] = (object) num10;
                      table.Rows.Add(row4);
                      ++num4;
                      num5 -= num10;
                      val2_2 -= num10;
                      num2 = val1_2 - num10;
                      row1.BeginEdit();
                      row1["NEED"] = (object) (Convert.ToInt32(row1["NEED"]) - num10);
                      row1.EndEdit();
                    }
                  }
                }
              }
              else
                break;
            }
            ++num7;
            if (num7 > 300)
              num6 = 0;
          }
        }
      }
    }

    private static void central_rpl_stockout_buying_reserve(
      DataSet _DataSet,
      string _TargetDataTableName)
    {
      DataTable table = _DataSet.Tables[_TargetDataTableName];
      DataTable dataTable1 = new DataTable();
      DataTable dataTable2 = ((IEnumerable<DataRow>) table.Select("a>0 and b>0 and f>0 and i>0")).CopyToDataTable<DataRow>();
      table.Rows.Clear();
      dataTable2.Columns.Add("SKU");
      dataTable2.Columns.Add("NEED");
      foreach (DataRow row in (InternalDataCollectionBase) dataTable2.Rows)
      {
        string str = row["REGIONAL_WH_SKU_SIZE"].ToString();
        int startIndex = str.IndexOf("_", 0, str.Length) + 1;
        int length = str.Length;
        if (startIndex <= 0)
          row["a"] = (object) -1;
        else
          row["SKU"] = (object) str.ToString().Substring(startIndex, length - startIndex);
        row["NEED"] = row["b"];
      }
      DataTable dataTable3 = new DataTable();
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      int num4 = 0;
      foreach (string str in dataTable2.AsEnumerable().Select<DataRow, string>((System.Func<DataRow, string>) (SKU => SKU[nameof (SKU)].ToString())).Distinct<string>().ToList<string>())
      {
        dataTable3.Clear();
        dataTable3 = ((IEnumerable<DataRow>) dataTable2.Select("SKU = '" + str + "'")).CopyToDataTable<DataRow>();
        int val2_1 = 0;
        foreach (DataRow row in (InternalDataCollectionBase) dataTable3.Rows)
          val2_1 += Convert.ToInt32(row["h"]);
        int val2_2 = Math.Min(Convert.ToInt32(dataTable3.Rows[0]["i"]), val2_1);
        int val2_3 = Convert.ToInt32(dataTable3.Rows[0]["i"]) - val2_2;
        int num5 = 0;
        foreach (DataRow row in (InternalDataCollectionBase) dataTable3.Rows)
          num5 += Convert.ToInt32(row["NEED"]);
        if ((val2_2 > 0 || val2_3 > 0) && num5 > 0 && ((IEnumerable<DataRow>) dataTable3.Select("a>0 and NEED>0")).Count<DataRow>() > 0)
        {
          DataTable dataTable4 = ((IEnumerable<DataRow>) dataTable3.Select("a>0 and NEED>0")).CopyToDataTable<DataRow>();
          dataTable4.DefaultView.Sort = "a asc";
          dataTable3 = dataTable4.DefaultView.ToTable();
          int num6 = 1;
          int num7 = 0;
          while (num6 == 1)
          {
            foreach (DataRow row1 in (InternalDataCollectionBase) dataTable3.Rows)
            {
              if ((val2_2 > 0 || val2_3 > 0) && num5 != 0)
              {
                if (Convert.ToInt32(row1["NEED"]) > 0)
                {
                  int int32 = Convert.ToInt32(Math.Min(Convert.ToInt32(row1["NEED"]), Convert.ToInt32(row1["h"])));
                  int val1 = Math.Max(Convert.ToInt32(row1["NEED"]) - int32, 0);
                  int num8 = 0;
                  if (int32 > 0 && num8 == 0)
                  {
                    num3 = 0;
                    int num9 = Math.Min(Math.Min(int32, val2_2), 1);
                    if (num9 > 0)
                    {
                      DataRow row2 = table.NewRow();
                      row2["ID"] = (object) num4;
                      row2["REGIONAL_WH_SKU_SIZE"] = (object) row1["REGIONAL_WH_SKU_SIZE"].ToString();
                      row2["j"] = (object) num9;
                      table.Rows.Add(row2);
                      ++num4;
                      num5 -= num9;
                      val2_2 -= num9;
                      num1 = int32 - num9;
                      row1.BeginEdit();
                      row1["NEED"] = (object) (Convert.ToInt32(row1["NEED"]) - num9);
                      row1["h"] = (object) (Convert.ToInt32(row1["h"]) - num9);
                      row1.EndEdit();
                      continue;
                    }
                    num3 = 0;
                    num8 = Math.Min(Math.Min(int32, val2_3), 1);
                    if (num8 > 0)
                    {
                      DataRow row3 = table.NewRow();
                      row3["ID"] = (object) num4;
                      row3["REGIONAL_WH_SKU_SIZE"] = (object) row1["REGIONAL_WH_SKU_SIZE"].ToString();
                      row3["j"] = (object) num8;
                      table.Rows.Add(row3);
                      ++num4;
                      num5 -= num8;
                      val2_3 -= num8;
                      num1 = int32 - num8;
                      row1.BeginEdit();
                      row1["NEED"] = (object) (Convert.ToInt32(row1["NEED"]) - num8);
                      row1["h"] = (object) (Convert.ToInt32(row1["h"]) - num8);
                      row1.EndEdit();
                      continue;
                    }
                  }
                  if (val1 > 0 && num8 == 0)
                  {
                    num3 = 0;
                    int num10 = Math.Min(Math.Min(val1, val2_3), 1);
                    if (num10 > 0)
                    {
                      DataRow row4 = table.NewRow();
                      row4["ID"] = (object) num4;
                      row4["REGIONAL_WH_SKU_SIZE"] = (object) row1["REGIONAL_WH_SKU_SIZE"].ToString();
                      row4["j"] = (object) num10;
                      table.Rows.Add(row4);
                      ++num4;
                      num5 -= num10;
                      val2_3 -= num10;
                      num2 = val1 - num10;
                      row1.BeginEdit();
                      row1["NEED"] = (object) (Convert.ToInt32(row1["NEED"]) - num10);
                      row1.EndEdit();
                    }
                  }
                }
              }
              else
                break;
            }
            ++num7;
            if (num7 > 300)
              num6 = 0;
          }
        }
      }
    }

    private static void central_rpl_woh_buying_reserve(
      DataSet _DataSet,
      string _TargetDataTableName)
    {
      DataTable table = _DataSet.Tables[_TargetDataTableName];
      DataTable dataTable1 = new DataTable();
      DataTable dataTable2 = ((IEnumerable<DataRow>) table.Select("a>0 and f>0 and f>g and i>0")).CopyToDataTable<DataRow>();
      table.Rows.Clear();
      dataTable2.Columns.Add("SKU");
      dataTable2.Columns.Add("NEED");
      dataTable2.Columns.Add("POH");
      dataTable2.Columns.Add("WOH");
      foreach (DataRow row in (InternalDataCollectionBase) dataTable2.Rows)
      {
        string str = row["REGIONAL_WH_SKU_SIZE"].ToString();
        int startIndex = str.IndexOf("_", 0, str.Length) + 1;
        int length = str.Length;
        if (startIndex <= 0)
          row["a"] = (object) -1;
        else
          row["SKU"] = (object) str.ToString().Substring(startIndex, length - startIndex);
        row["NEED"] = (object) (Convert.ToInt32(row["f"]) - Convert.ToInt32(row["g"]));
        row["POH"] = (object) Convert.ToInt32(row["g"]);
        if (Convert.ToDouble(row["d"]) == 0.0 && Convert.ToInt32(row["POH"]) == 0)
        {
          row["WOH"] = (object) 0;
        }
        else
        {
          int num = Convert.ToDouble(row["d"]) != 0.0 ? 0 : (Convert.ToInt32(row["POH"]) > 0 ? 1 : 0);
          row["WOH"] = num == 0 ? (object) (Convert.ToDouble(row["POH"]) / Convert.ToDouble(row["d"])) : (object) 99999;
        }
      }
      DataTable dataTable3 = new DataTable();
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      int num4 = 0;
      foreach (string str in dataTable2.AsEnumerable().Select<DataRow, string>((System.Func<DataRow, string>) (SKU => SKU[nameof (SKU)].ToString())).Distinct<string>().ToList<string>())
      {
        dataTable3.Clear();
        dataTable3 = ((IEnumerable<DataRow>) dataTable2.Select("SKU = '" + str + "'")).CopyToDataTable<DataRow>();
        int val2_1 = 0;
        foreach (DataRow row in (InternalDataCollectionBase) dataTable3.Rows)
          val2_1 += Convert.ToInt32(row["h"]);
        int val2_2 = Math.Min(Convert.ToInt32(dataTable3.Rows[0]["i"]), val2_1);
        int val2_3 = Convert.ToInt32(dataTable3.Rows[0]["i"]) - val2_2;
        int num5 = 0;
        foreach (DataRow row in (InternalDataCollectionBase) dataTable3.Rows)
          num5 += Convert.ToInt32(row["NEED"]);
        if ((val2_2 > 0 || val2_3 > 0) && num5 > 0 && ((IEnumerable<DataRow>) dataTable3.Select("a>0 and NEED>0")).Count<DataRow>() > 0)
        {
          DataTable dataTable4 = ((IEnumerable<DataRow>) dataTable3.Select("a>0 and NEED>0")).CopyToDataTable<DataRow>();
          dataTable4.DefaultView.Sort = "WOH asc, a asc";
          dataTable3 = dataTable4.DefaultView.ToTable();
          int num6 = 1;
          int num7 = 0;
          while (num6 == 1)
          {
            foreach (DataRow row1 in (InternalDataCollectionBase) dataTable3.Rows)
            {
              if ((val2_2 > 0 || val2_3 > 0) && num5 != 0)
              {
                if (Convert.ToInt32(row1["NEED"]) > 0)
                {
                  int val1_1 = Math.Min(Convert.ToInt32(row1["NEED"]), Convert.ToInt32(row1["h"]));
                  int val1_2 = Math.Max(Convert.ToInt32(row1["NEED"]) - val1_1, 0);
                  int num8 = 0;
                  if (val1_1 > 0 && num8 == 0)
                  {
                    num3 = 0;
                    int num9 = Math.Min(Math.Min(val1_1, val2_2), 1);
                    if (num9 > 0)
                    {
                      DataRow row2 = table.NewRow();
                      row2["ID"] = (object) num4;
                      row2["REGIONAL_WH_SKU_SIZE"] = (object) row1["REGIONAL_WH_SKU_SIZE"].ToString();
                      row2["j"] = (object) num9;
                      table.Rows.Add(row2);
                      ++num4;
                      num5 -= num9;
                      val2_2 -= num9;
                      num1 = val1_1 - num9;
                      row1.BeginEdit();
                      row1["NEED"] = (object) (Convert.ToInt32(row1["NEED"]) - num9);
                      row1["h"] = (object) (Convert.ToInt32(row1["h"]) - num9);
                      row1["POH"] = (object) (Convert.ToInt32(row1["POH"]) + num9);
                      if (Convert.ToDouble(row1["d"]) == 0.0 && Convert.ToInt32(row1["POH"]) == 0)
                      {
                        row1["WOH"] = (object) 0;
                      }
                      else
                      {
                        int num10 = Convert.ToDouble(row1["d"]) != 0.0 ? 0 : (Convert.ToInt32(row1["POH"]) > 0 ? 1 : 0);
                        row1["WOH"] = num10 == 0 ? (object) (Convert.ToDouble(row1["POH"]) / (double) Convert.ToInt32(row1["d"])) : (object) 99999;
                      }
                      row1.EndEdit();
                      continue;
                    }
                    num3 = 0;
                    num8 = Math.Min(Math.Min(val1_1, val2_3), 1);
                    if (num8 > 0)
                    {
                      DataRow row3 = table.NewRow();
                      row3["ID"] = (object) num4;
                      row3["REGIONAL_WH_SKU_SIZE"] = (object) row1["REGIONAL_WH_SKU_SIZE"].ToString();
                      row3["j"] = (object) num8;
                      table.Rows.Add(row3);
                      ++num4;
                      num5 -= num8;
                      val2_3 -= num8;
                      num1 = val1_1 - num8;
                      row1.BeginEdit();
                      row1["NEED"] = (object) (Convert.ToInt32(row1["NEED"]) - num8);
                      row1["h"] = (object) (Convert.ToInt32(row1["h"]) - num8);
                      row1["POH"] = (object) (Convert.ToInt32(row1["POH"]) + num8);
                      if (Convert.ToDouble(row1["d"]) == 0.0 && Convert.ToInt32(row1["POH"]) == 0)
                      {
                        row1["WOH"] = (object) 0;
                      }
                      else
                      {
                        int num11 = Convert.ToDouble(row1["d"]) != 0.0 ? 0 : (Convert.ToInt32(row1["POH"]) > 0 ? 1 : 0);
                        row1["WOH"] = num11 == 0 ? (object) (Convert.ToDouble(row1["POH"]) / (double) Convert.ToInt32(row1["d"])) : (object) 99999;
                      }
                      row1.EndEdit();
                      continue;
                    }
                  }
                  if (val1_2 > 0 && num8 == 0)
                  {
                    num3 = 0;
                    int num12 = Math.Min(Math.Min(val1_2, val2_3), 1);
                    if (num12 > 0)
                    {
                      DataRow row4 = table.NewRow();
                      row4["ID"] = (object) num4;
                      row4["REGIONAL_WH_SKU_SIZE"] = (object) row1["REGIONAL_WH_SKU_SIZE"].ToString();
                      row4["j"] = (object) num12;
                      table.Rows.Add(row4);
                      ++num4;
                      num5 -= num12;
                      val2_3 -= num12;
                      num2 = val1_2 - num12;
                      row1.BeginEdit();
                      row1["NEED"] = (object) (Convert.ToInt32(row1["NEED"]) - num12);
                      row1["POH"] = (object) (Convert.ToInt32(row1["POH"]) + num12);
                      if (Convert.ToDouble(row1["d"]) == 0.0 && Convert.ToInt32(row1["POH"]) == 0)
                      {
                        row1["WOH"] = (object) 0;
                      }
                      else
                      {
                        int num13 = Convert.ToDouble(row1["d"]) != 0.0 ? 0 : (Convert.ToInt32(row1["POH"]) > 0 ? 1 : 0);
                        row1["WOH"] = num13 == 0 ? (object) (Convert.ToDouble(row1["POH"]) / (double) Convert.ToInt32(row1["d"])) : (object) 99999;
                      }
                      row1.EndEdit();
                    }
                  }
                }
              }
              else
                break;
            }
            ++num7;
            if (num7 > 300)
              num6 = 0;
          }
        }
      }
    }

    private static void central_rpl_wohsub_buying_reserve(
      DataSet _DataSet,
      string _TargetDataTableName)
    {
      DataTable table = _DataSet.Tables[_TargetDataTableName];
      DataTable dataTable1 = new DataTable();
      DataTable dataTable2 = ((IEnumerable<DataRow>) table.Select("a>0 and f>0 and f>g and i>0")).CopyToDataTable<DataRow>();
      table.Rows.Clear();
      dataTable2.Columns.Add("SKU");
      dataTable2.Columns.Add("NEED");
      foreach (DataRow row in (InternalDataCollectionBase) dataTable2.Rows)
      {
        string str = row["REGIONAL_WH_SKU_SIZE"].ToString();
        int startIndex = str.IndexOf("_", 0, str.Length) + 1;
        int length = str.Length;
        if (startIndex <= 0)
          row["a"] = (object) -1;
        else
          row["SKU"] = (object) str.ToString().Substring(startIndex, length - startIndex);
        row["NEED"] = (object) (Convert.ToInt32(row["f"]) - Convert.ToInt32(row["g"]));
      }
      DataTable dataTable3 = new DataTable();
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      int num4 = 0;
      foreach (string str in dataTable2.AsEnumerable().Select<DataRow, string>((System.Func<DataRow, string>) (SKU => SKU[nameof (SKU)].ToString())).Distinct<string>().ToList<string>())
      {
        dataTable3.Clear();
        dataTable3 = ((IEnumerable<DataRow>) dataTable2.Select("SKU = '" + str + "'")).CopyToDataTable<DataRow>();
        int val2_1 = 0;
        foreach (DataRow row in (InternalDataCollectionBase) dataTable3.Rows)
          val2_1 += Convert.ToInt32(row["h"]);
        int val2_2 = Math.Min(Convert.ToInt32(dataTable3.Rows[0]["i"]), val2_1);
        int val2_3 = Convert.ToInt32(dataTable3.Rows[0]["i"]) - val2_2;
        int num5 = 0;
        foreach (DataRow row in (InternalDataCollectionBase) dataTable3.Rows)
          num5 += Convert.ToInt32(row["NEED"]);
        if ((val2_2 > 0 || val2_3 > 0) && num5 > 0 && ((IEnumerable<DataRow>) dataTable3.Select("a>0 and NEED>0")).Count<DataRow>() > 0)
        {
          DataTable dataTable4 = ((IEnumerable<DataRow>) dataTable3.Select("a>0 and NEED>0")).CopyToDataTable<DataRow>();
          dataTable4.DefaultView.Sort = "e asc, a asc";
          dataTable3 = dataTable4.DefaultView.ToTable();
          foreach (DataRow row1 in (InternalDataCollectionBase) dataTable3.Rows)
          {
            if ((val2_2 > 0 || val2_3 > 0) && num5 != 0)
            {
              if (Convert.ToInt32(row1["NEED"]) > 0)
              {
                int val1_1 = Math.Min(Convert.ToInt32(row1["NEED"]), Convert.ToInt32(row1["h"]));
                int val1_2 = Math.Max(Convert.ToInt32(row1["NEED"]) - val1_1, 0);
                num3 = 0;
                if (val1_1 > 0)
                {
                  num3 = 0;
                  int num6 = Math.Min(val1_1, val2_2);
                  if (num6 > 0)
                  {
                    DataRow row2 = table.NewRow();
                    row2["ID"] = (object) num4;
                    row2["REGIONAL_WH_SKU_SIZE"] = (object) row1["REGIONAL_WH_SKU_SIZE"].ToString();
                    row2["j"] = (object) num6;
                    table.Rows.Add(row2);
                    ++num4;
                    num5 -= num6;
                    val2_2 -= num6;
                    val1_1 -= num6;
                    row1.BeginEdit();
                    row1["NEED"] = (object) (Convert.ToInt32(row1["NEED"]) - num6);
                    row1["h"] = (object) (Convert.ToInt32(row1["h"]) - num6);
                    row1.EndEdit();
                  }
                  num3 = 0;
                  int num7 = Math.Min(val1_1, val2_3);
                  if (num7 > 0)
                  {
                    DataRow row3 = table.NewRow();
                    row3["ID"] = (object) num4;
                    row3["REGIONAL_WH_SKU_SIZE"] = (object) row1["REGIONAL_WH_SKU_SIZE"].ToString();
                    row3["j"] = (object) num7;
                    table.Rows.Add(row3);
                    ++num4;
                    num5 -= num7;
                    val2_3 -= num7;
                    num1 = val1_1 - num7;
                    row1.BeginEdit();
                    row1["NEED"] = (object) (Convert.ToInt32(row1["NEED"]) - num7);
                    row1["h"] = (object) (Convert.ToInt32(row1["h"]) - num7);
                    row1.EndEdit();
                  }
                }
                if (val1_2 > 0)
                {
                  num3 = 0;
                  int num8 = Math.Min(val1_2, val2_3);
                  if (num8 > 0)
                  {
                    DataRow row4 = table.NewRow();
                    row4["ID"] = (object) num4;
                    row4["REGIONAL_WH_SKU_SIZE"] = (object) row1["REGIONAL_WH_SKU_SIZE"].ToString();
                    row4["j"] = (object) num8;
                    table.Rows.Add(row4);
                    ++num4;
                    num5 -= num8;
                    val2_3 -= num8;
                    num2 = val1_2 - num8;
                    row1.BeginEdit();
                    row1["NEED"] = (object) (Convert.ToInt32(row1["NEED"]) - num8);
                    row1.EndEdit();
                  }
                }
              }
            }
            else
              break;
          }
        }
      }
    }

    private static void central_rpl_fixed_buying_reserve(
      DataSet _DataSet,
      string _TargetDataTableName)
    {
      DataTable table = _DataSet.Tables[_TargetDataTableName];
      DataTable dataTable1 = new DataTable();
      DataTable dataTable2 = ((IEnumerable<DataRow>) table.Select("a>0 and f>0 and f>g and i>0")).CopyToDataTable<DataRow>();
      table.Rows.Clear();
      dataTable2.Columns.Add("SKU");
      dataTable2.Columns.Add("NEED");
      foreach (DataRow row in (InternalDataCollectionBase) dataTable2.Rows)
      {
        string str = row["REGIONAL_WH_SKU_SIZE"].ToString();
        int startIndex = str.IndexOf("_", 0, str.Length) + 1;
        int length = str.Length;
        if (startIndex <= 0)
          row["a"] = (object) -1;
        else
          row["SKU"] = (object) str.ToString().Substring(startIndex, length - startIndex);
        row["NEED"] = (object) (Convert.ToInt32(row["f"]) - Convert.ToInt32(row["g"]));
      }
      DataTable dataTable3 = new DataTable();
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      int num4 = 0;
      foreach (string str in dataTable2.AsEnumerable().Select<DataRow, string>((System.Func<DataRow, string>) (SKU => SKU[nameof (SKU)].ToString())).Distinct<string>().ToList<string>())
      {
        dataTable3.Clear();
        dataTable3 = ((IEnumerable<DataRow>) dataTable2.Select("SKU = '" + str + "'")).CopyToDataTable<DataRow>();
        int val2_1 = 0;
        foreach (DataRow row in (InternalDataCollectionBase) dataTable3.Rows)
          val2_1 += Convert.ToInt32(row["h"]);
        int val2_2 = Math.Min(Convert.ToInt32(dataTable3.Rows[0]["i"]), val2_1);
        int val2_3 = Convert.ToInt32(dataTable3.Rows[0]["i"]) - val2_2;
        int num5 = 0;
        foreach (DataRow row in (InternalDataCollectionBase) dataTable3.Rows)
          num5 += Convert.ToInt32(row["NEED"]);
        if ((val2_2 > 0 || val2_3 > 0) && num5 > 0 && ((IEnumerable<DataRow>) dataTable3.Select("a>0 and NEED>0")).Count<DataRow>() > 0)
        {
          DataTable dataTable4 = ((IEnumerable<DataRow>) dataTable3.Select("a>0 and NEED>0")).CopyToDataTable<DataRow>();
          dataTable4.DefaultView.Sort = "a asc";
          dataTable3 = dataTable4.DefaultView.ToTable();
          foreach (DataRow row1 in (InternalDataCollectionBase) dataTable3.Rows)
          {
            if ((val2_2 > 0 || val2_3 > 0) && num5 != 0)
            {
              if (Convert.ToInt32(row1["NEED"]) > 0)
              {
                int val1_1 = Math.Min(Convert.ToInt32(row1["NEED"]), Convert.ToInt32(row1["h"]));
                int val1_2 = Math.Max(Convert.ToInt32(row1["NEED"]) - val1_1, 0);
                num3 = 0;
                if (val1_1 > 0)
                {
                  num3 = 0;
                  int num6 = Math.Min(val1_1, val2_2);
                  if (num6 > 0)
                  {
                    DataRow row2 = table.NewRow();
                    row2["ID"] = (object) num4;
                    row2["REGIONAL_WH_SKU_SIZE"] = (object) row1["REGIONAL_WH_SKU_SIZE"].ToString();
                    row2["j"] = (object) num6;
                    table.Rows.Add(row2);
                    ++num4;
                    num5 -= num6;
                    val2_2 -= num6;
                    val1_1 -= num6;
                    row1.BeginEdit();
                    row1["NEED"] = (object) (Convert.ToInt32(row1["NEED"]) - num6);
                    row1["h"] = (object) (Convert.ToInt32(row1["h"]) - num6);
                    row1.EndEdit();
                  }
                  num3 = 0;
                  int num7 = Math.Min(val1_1, val2_3);
                  if (num7 > 0)
                  {
                    DataRow row3 = table.NewRow();
                    row3["ID"] = (object) num4;
                    row3["REGIONAL_WH_SKU_SIZE"] = (object) row1["REGIONAL_WH_SKU_SIZE"].ToString();
                    row3["j"] = (object) num7;
                    table.Rows.Add(row3);
                    ++num4;
                    num5 -= num7;
                    val2_3 -= num7;
                    num1 = val1_1 - num7;
                    row1.BeginEdit();
                    row1["NEED"] = (object) (Convert.ToInt32(row1["NEED"]) - num7);
                    row1["h"] = (object) (Convert.ToInt32(row1["h"]) - num7);
                    row1.EndEdit();
                  }
                }
                if (val1_2 > 0)
                {
                  num3 = 0;
                  int num8 = Math.Min(val1_2, val2_3);
                  if (num8 > 0)
                  {
                    DataRow row4 = table.NewRow();
                    row4["ID"] = (object) num4;
                    row4["REGIONAL_WH_SKU_SIZE"] = (object) row1["REGIONAL_WH_SKU_SIZE"].ToString();
                    row4["j"] = (object) num8;
                    table.Rows.Add(row4);
                    ++num4;
                    num5 -= num8;
                    val2_3 -= num8;
                    num2 = val1_2 - num8;
                    row1.BeginEdit();
                    row1["NEED"] = (object) (Convert.ToInt32(row1["NEED"]) - num8);
                    row1.EndEdit();
                  }
                }
              }
            }
            else
              break;
          }
        }
      }
    }

    private static void central_push_gdo(DataSet _DataSet, string _TargetDataTableName)
    {
      DataTable table = _DataSet.Tables[_TargetDataTableName];
      DataTable dataTable1 = new DataTable();
      DataTable dataTable2 = ((IEnumerable<DataRow>) table.Select("a>0 and b>0 and c=0 and f>0")).CopyToDataTable<DataRow>();
      table.Rows.Clear();
      dataTable2.Columns.Add("SKU");
      dataTable2.Columns.Add("NEED");
      foreach (DataRow row in (InternalDataCollectionBase) dataTable2.Rows)
      {
        string str = row["REGIONAL_WH_SKU_SIZE"].ToString();
        int startIndex = str.IndexOf("_", 0, str.Length) + 1;
        int length = str.Length;
        if (startIndex <= 0)
          row["a"] = (object) -1;
        else
          row["SKU"] = (object) str.ToString().Substring(startIndex, length - startIndex);
        row["NEED"] = (object) 1;
      }
      DataTable dataTable3 = new DataTable();
      int num1 = 0;
      int num2 = 0;
      foreach (string str in dataTable2.AsEnumerable().Select<DataRow, string>((System.Func<DataRow, string>) (SKU => SKU[nameof (SKU)].ToString())).Distinct<string>().ToList<string>())
      {
        dataTable3.Clear();
        DataTable dataTable4 = ((IEnumerable<DataRow>) dataTable2.Select("SKU = '" + str + "'")).CopyToDataTable<DataRow>();
        num1 = 0;
        int int32 = Convert.ToInt32(dataTable4.Rows[0]["f"]);
        dataTable4.DefaultView.Sort = "d desc, a asc";
        dataTable3 = dataTable4.DefaultView.ToTable();
        foreach (DataRow row1 in (InternalDataCollectionBase) dataTable3.Rows)
        {
          int num3 = Math.Min(int32, Convert.ToInt32(row1["NEED"]));
          DataRow row2 = table.NewRow();
          row2["ID"] = (object) num2;
          row2["REGIONAL_WH_SKU_SIZE"] = (object) row1["REGIONAL_WH_SKU_SIZE"].ToString();
          row2["g"] = (object) num3;
          table.Rows.Add(row2);
          ++num2;
          int32 -= num3;
          row1.BeginEdit();
          row1["NEED"] = (object) (Convert.ToInt32(row1["NEED"]) - num3);
          row1.EndEdit();
        }
      }
    }

    private static void central_push_fixed(DataSet _DataSet, string _TargetDataTableName)
    {
      DataTable table = _DataSet.Tables[_TargetDataTableName];
      DataTable dataTable1 = new DataTable();
      DataTable dataTable2 = ((IEnumerable<DataRow>) table.Select("a>0 and b>0 and c=0 and f>0")).CopyToDataTable<DataRow>();
      table.Rows.Clear();
      dataTable2.Columns.Add("SKU");
      dataTable2.Columns.Add("NEED");
      foreach (DataRow row in (InternalDataCollectionBase) dataTable2.Rows)
      {
        string str = row["REGIONAL_WH_SKU_SIZE"].ToString();
        int startIndex = str.IndexOf("_", 0, str.Length) + 1;
        int length = str.Length;
        if (startIndex <= 0)
          row["a"] = (object) -1;
        else
          row["SKU"] = (object) str.ToString().Substring(startIndex, length - startIndex);
        row["NEED"] = (object) 1;
      }
      DataTable dataTable3 = new DataTable();
      int num1 = 0;
      int num2 = 0;
      foreach (string str in dataTable2.AsEnumerable().Select<DataRow, string>((System.Func<DataRow, string>) (SKU => SKU[nameof (SKU)].ToString())).Distinct<string>().ToList<string>())
      {
        dataTable3.Clear();
        DataTable dataTable4 = ((IEnumerable<DataRow>) dataTable2.Select("SKU = '" + str + "'")).CopyToDataTable<DataRow>();
        num1 = 0;
        int int32 = Convert.ToInt32(dataTable4.Rows[0]["f"]);
        dataTable4.DefaultView.Sort = "a asc";
        dataTable3 = dataTable4.DefaultView.ToTable();
        foreach (DataRow row1 in (InternalDataCollectionBase) dataTable3.Rows)
        {
          int num3 = Math.Min(int32, Convert.ToInt32(row1["NEED"]));
          DataRow row2 = table.NewRow();
          row2["ID"] = (object) num2;
          row2["REGIONAL_WH_SKU_SIZE"] = (object) row1["REGIONAL_WH_SKU_SIZE"].ToString();
          row2["g"] = (object) num3;
          table.Rows.Add(row2);
          ++num2;
          int32 -= num3;
          row1.BeginEdit();
          row1["NEED"] = (object) (Convert.ToInt32(row1["NEED"]) - num3);
          row1.EndEdit();
        }
      }
    }

    private static void central_push_woh(DataSet _DataSet, string _TargetDataTableName)
    {
      DataTable table1 = _DataSet.Tables[_TargetDataTableName];
      DataTable dataTable1 = new DataTable();
      DataTable dataTable2 = ((IEnumerable<DataRow>) table1.Select("a>0 and b>0 and c=0 and f>0")).CopyToDataTable<DataRow>();
      table1.Rows.Clear();
      dataTable2.Columns.Add("SKU");
      dataTable2.Columns.Add("NEED");
      dataTable2.Columns.Add("POH");
      dataTable2.Columns.Add("WOH", typeof (double));
      foreach (DataRow row in (InternalDataCollectionBase) dataTable2.Rows)
      {
        string str = row["REGIONAL_WH_SKU_SIZE"].ToString();
        int startIndex = str.IndexOf("_", 0, str.Length) + 1;
        int length = str.Length;
        if (startIndex <= 0)
          row["a"] = (object) -1;
        else
          row["SKU"] = (object) str.ToString().Substring(startIndex, length - startIndex);
        row["NEED"] = (object) 1;
        row["POH"] = (object) Convert.ToInt32(row["e"]);
        if (Convert.ToDouble(row["d"]) == 0.0 && Convert.ToInt32(row["POH"]) == 0)
        {
          row["WOH"] = (object) 0;
        }
        else
        {
          int num = Convert.ToDouble(row["d"]) != 0.0 ? 0 : (Convert.ToInt32(row["POH"]) > 0 ? 1 : 0);
          row["WOH"] = num == 0 ? (object) (Convert.ToDouble(row["POH"]) / Convert.ToDouble(row["d"])) : (object) 9999;
        }
      }
      DataTable dataTable3 = new DataTable();
      int num1 = 0;
      int num2 = 0;
      foreach (string str in dataTable2.AsEnumerable().Select<DataRow, string>((System.Func<DataRow, string>) (SKU => SKU[nameof (SKU)].ToString())).Distinct<string>().ToList<string>())
      {
        dataTable3.Clear();
        DataTable dataTable4 = ((IEnumerable<DataRow>) dataTable2.Select("SKU = '" + str + "'")).CopyToDataTable<DataRow>();
        num1 = 0;
        int int32 = Convert.ToInt32(dataTable4.Rows[0]["f"]);
        dataTable4.DefaultView.Sort = "WOH asc, a asc";
        DataTable table2 = dataTable4.DefaultView.ToTable();
        foreach (DataRow row1 in (InternalDataCollectionBase) table2.Rows)
        {
          int num3 = Math.Min(int32, Convert.ToInt32(row1["NEED"]));
          DataRow row2 = table1.NewRow();
          row2["ID"] = (object) num2;
          row2["REGIONAL_WH_SKU_SIZE"] = (object) row1["REGIONAL_WH_SKU_SIZE"].ToString();
          row2["g"] = (object) num3;
          table1.Rows.Add(row2);
          ++num2;
          int32 -= num3;
          row1.BeginEdit();
          row1["POH"] = (object) (Convert.ToInt32(row1["POH"]) + num3);
          if (Convert.ToDouble(row1["d"]) == 0.0 && Convert.ToInt32(row1["POH"]) == 0)
          {
            row1["WOH"] = (object) 0;
          }
          else
          {
            int num4 = Convert.ToDouble(row1["d"]) != 0.0 ? 0 : (Convert.ToInt32(row1["POH"]) > 0 ? 1 : 0);
            row1["WOH"] = num4 == 0 ? (object) ((double) Convert.ToInt32(row1["POH"]) / Convert.ToDouble(row1["d"])) : (object) 9999;
          }
          row1["NEED"] = (object) (Convert.ToInt32(row1["NEED"]) - num3);
          row1.EndEdit();
        }
        table2.DefaultView.Sort = "WOH asc, a asc";
        dataTable3 = table2.DefaultView.ToTable();
      }
    }

    private static void central_rblres_gdo(DataSet _DataSet, string _TargetDataTableName)
    {
      DataTable table1 = _DataSet.Tables[_TargetDataTableName];
      DataTable dataTable1 = new DataTable();
      DataTable dataTable2 = ((IEnumerable<DataRow>) table1.Select("a>0 and (e>0 or f<0) and j=0")).CopyToDataTable<DataRow>();
      table1.Rows.Clear();
      dataTable2.Columns.Add(new DataColumn("SKU_GEO", typeof (string)));
      dataTable2.Columns.Add(new DataColumn("NEED", typeof (int)));
      foreach (DataRow row in (InternalDataCollectionBase) dataTable2.Rows)
      {
        row["SKU_GEO"] = (object) Convert.ToString(row["SKU_SIZE"]);
        row["NEED"] = Convert.ToInt32(row["e"]) <= 0 ? (object) Convert.ToInt32(row["f"]) : (object) Convert.ToInt32(row["e"]);
      }
      dataTable2.Clone();
      dataTable2.Clone();
      DataTable dataTable3 = dataTable2.Clone();
      DataTable dataTable4 = dataTable2.Clone();
      int num1 = 0;
      DataTable dataTable5 = ((IEnumerable<DataRow>) dataTable2.Select("NEED>0")).CopyToDataTable<DataRow>();
      DataTable dataTable6 = ((IEnumerable<DataRow>) dataTable2.Select("NEED<0")).CopyToDataTable<DataRow>();
      foreach (object obj in dataTable5.AsEnumerable().Select<DataRow, string>((System.Func<DataRow, string>) (SKU_SIZE => SKU_SIZE[nameof (SKU_SIZE)].ToString())).Distinct<string>().ToList<string>())
      {
        string str = obj.ToString();
        dataTable3.Rows.Clear();
        dataTable4.Rows.Clear();
        if (((IEnumerable<DataRow>) dataTable5.Select("SKU_SIZE='" + str + "'")).Count<DataRow>() > 0)
          dataTable3 = ((IEnumerable<DataRow>) dataTable5.Select("SKU_SIZE='" + str + "'")).CopyToDataTable<DataRow>();
        if (((IEnumerable<DataRow>) dataTable6.Select("SKU_SIZE='" + str + "'")).Count<DataRow>() > 0)
          dataTable4 = ((IEnumerable<DataRow>) dataTable6.Select("SKU_SIZE='" + str + "'")).CopyToDataTable<DataRow>();
        DataTable table2 = dataTable3.DefaultView.ToTable();
        table2.DefaultView.Sort = "g desc, a asc";
        dataTable3 = table2.DefaultView.ToTable();
        DataTable table3 = dataTable4.DefaultView.ToTable();
        table3.DefaultView.Sort = "k asc, g asc, a desc";
        dataTable4 = table3.DefaultView.ToTable();
        foreach (DataRow row1 in (InternalDataCollectionBase) dataTable3.Rows)
        {
          foreach (DataRow row2 in (InternalDataCollectionBase) dataTable4.Rows)
          {
            if (Convert.ToInt32(row1["NEED"]) > 0 && Convert.ToInt32(row2["NEED"]) < 0)
            {
              int num2 = Math.Min(Convert.ToInt32(row1["NEED"]), Convert.ToInt32(row2["NEED"]) * -1);
              if (num2 > 0)
              {
                ++num1;
                DataRow row3 = table1.NewRow();
                row3["ID"] = (object) num1;
                row3["SKU_SIZE"] = row1["SKU_SIZE"];
                row3["RESERVES"] = row1["RESERVES"];
                row3["RESERVES_SA"] = row2["RESERVES_SA"];
                row3["l"] = (object) num2;
                table1.Rows.Add(row3);
                ++num1;
                DataRow row4 = table1.NewRow();
                row4["ID"] = (object) num1;
                row4["SKU_SIZE"] = row2["SKU_SIZE"];
                row4["RESERVES"] = row2["RESERVES"];
                row4["RESERVES_SA"] = row1["RESERVES_SA"];
                row4["m"] = (object) -num2;
                table1.Rows.Add(row4);
                row2.BeginEdit();
                row1.BeginEdit();
                row1["NEED"] = (object) (Convert.ToInt32(row1["NEED"]) - num2);
                row2["NEED"] = (object) (Convert.ToInt32(row2["NEED"]) + num2);
                row2.EndEdit();
                row1.EndEdit();
              }
            }
          }
        }
      }
    }

    private static void central_rblres_stockout(DataSet _DataSet, string _TargetDataTableName)
    {
      DataTable table1 = _DataSet.Tables[_TargetDataTableName];
      DataTable dataTable1 = new DataTable();
      DataTable dataTable2 = ((IEnumerable<DataRow>) table1.Select("a>0 and ((h=0 and e>0) or f<0) and j=0")).CopyToDataTable<DataRow>();
      table1.Rows.Clear();
      dataTable2.Columns.Add(new DataColumn("SKU_GEO", typeof (string)));
      dataTable2.Columns.Add(new DataColumn("NEED", typeof (int)));
      foreach (DataRow row in (InternalDataCollectionBase) dataTable2.Rows)
      {
        row["SKU_GEO"] = (object) Convert.ToString(row["SKU_SIZE"]);
        row["NEED"] = Convert.ToInt32(row["e"]) <= 0 ? (object) Convert.ToInt32(row["f"]) : (object) 1;
      }
      dataTable2.Clone();
      dataTable2.Clone();
      DataTable dataTable3 = dataTable2.Clone();
      DataTable dataTable4 = dataTable2.Clone();
      int num1 = 0;
      DataTable dataTable5 = ((IEnumerable<DataRow>) dataTable2.Select("NEED>0")).CopyToDataTable<DataRow>();
      DataTable dataTable6 = ((IEnumerable<DataRow>) dataTable2.Select("NEED<0")).CopyToDataTable<DataRow>();
      foreach (object obj in dataTable5.AsEnumerable().Select<DataRow, string>((System.Func<DataRow, string>) (SKU_SIZE => SKU_SIZE[nameof (SKU_SIZE)].ToString())).Distinct<string>().ToList<string>())
      {
        string str = obj.ToString();
        dataTable3.Rows.Clear();
        dataTable4.Rows.Clear();
        if (((IEnumerable<DataRow>) dataTable5.Select("SKU_SIZE='" + str + "'")).Count<DataRow>() > 0)
          dataTable3 = ((IEnumerable<DataRow>) dataTable5.Select("SKU_SIZE='" + str + "'")).CopyToDataTable<DataRow>();
        if (((IEnumerable<DataRow>) dataTable6.Select("SKU_SIZE='" + str + "'")).Count<DataRow>() > 0)
          dataTable4 = ((IEnumerable<DataRow>) dataTable6.Select("SKU_SIZE='" + str + "'")).CopyToDataTable<DataRow>();
        DataTable table2 = dataTable3.DefaultView.ToTable();
        table2.DefaultView.Sort = "a asc";
        dataTable3 = table2.DefaultView.ToTable();
        DataTable table3 = dataTable4.DefaultView.ToTable();
        table3.DefaultView.Sort = "k asc, g asc, a desc";
        dataTable4 = table3.DefaultView.ToTable();
        foreach (DataRow row1 in (InternalDataCollectionBase) dataTable3.Rows)
        {
          foreach (DataRow row2 in (InternalDataCollectionBase) dataTable4.Rows)
          {
            if (Convert.ToInt32(row1["NEED"]) > 0 && Convert.ToInt32(row2["NEED"]) < 0)
            {
              int num2 = Math.Min(Convert.ToInt32(row1["NEED"]), Convert.ToInt32(row2["NEED"]) * -1);
              if (num2 > 0)
              {
                ++num1;
                DataRow row3 = table1.NewRow();
                row3["ID"] = (object) num1;
                row3["SKU_SIZE"] = row1["SKU_SIZE"];
                row3["RESERVES"] = row1["RESERVES"];
                row3["RESERVES_SA"] = row2["RESERVES_SA"];
                row3["l"] = (object) num2;
                table1.Rows.Add(row3);
                ++num1;
                DataRow row4 = table1.NewRow();
                row4["ID"] = (object) num1;
                row4["SKU_SIZE"] = row2["SKU_SIZE"];
                row4["RESERVES"] = row2["RESERVES"];
                row4["RESERVES_SA"] = row1["RESERVES_SA"];
                row4["m"] = (object) -num2;
                table1.Rows.Add(row4);
                row2.BeginEdit();
                row1.BeginEdit();
                row1["NEED"] = (object) (Convert.ToInt32(row1["NEED"]) - num2);
                row2["NEED"] = (object) (Convert.ToInt32(row2["NEED"]) + num2);
                row2.EndEdit();
                row1.EndEdit();
              }
            }
          }
        }
      }
    }

    private static void reserve_rebalance_gdo(DataSet _DataSet, string _TargetDataTableName)
    {
      DataTable table1 = _DataSet.Tables[_TargetDataTableName];
      DataTable dataTable1 = new DataTable();
      DataTable dataTable2 = new DataTable();
      DataTable dataTable3 = new DataTable();
      DataTable dataTable4 = ((IEnumerable<DataRow>) table1.Select("a>0 and (d>0 or e<0)")).CopyToDataTable<DataRow>();
      table1.Rows.Clear();
      DataTable dataTable5 = ((IEnumerable<DataRow>) dataTable4.Select("d>0")).CopyToDataTable<DataRow>();
      DataTable dataTable6 = ((IEnumerable<DataRow>) dataTable4.Select("e<0")).CopyToDataTable<DataRow>();
      DataTable dataTable7 = dataTable5.Clone();
      DataTable dataTable8 = dataTable6.Clone();
      int num1 = 0;
      int num2 = 0;
      List<string> list1 = dataTable5.AsEnumerable().Select<DataRow, string>((System.Func<DataRow, string>) (SKU_SIZE => SKU_SIZE[nameof (SKU_SIZE)].ToString())).Distinct<string>().ToList<string>();
      List<string> list2 = dataTable6.AsEnumerable().Select<DataRow, string>((System.Func<DataRow, string>) (SKU_SIZE => SKU_SIZE[nameof (SKU_SIZE)].ToString())).Distinct<string>().ToList<string>();
      List<string> stringList = new List<string>();
      foreach (string str1 in list1)
      {
        foreach (string str2 in list2)
        {
          if (str1 == str2)
            stringList.Add(str1);
        }
      }
      foreach (string str in stringList)
      {
        dataTable7.Clear();
        dataTable8.Clear();
        if (((IEnumerable<DataRow>) dataTable5.Select("SKU_SIZE='" + str + "'")).Count<DataRow>() > 0)
          dataTable7 = ((IEnumerable<DataRow>) dataTable5.Select("SKU_SIZE='" + str + "'")).CopyToDataTable<DataRow>();
        if (((IEnumerable<DataRow>) dataTable6.Select("SKU_SIZE='" + str + "'")).Count<DataRow>() > 0)
          dataTable8 = ((IEnumerable<DataRow>) dataTable6.Select("SKU_SIZE='" + str + "'")).CopyToDataTable<DataRow>();
        DataTable table2 = dataTable7.DefaultView.ToTable();
        table2.DefaultView.Sort = "b desc, a asc";
        dataTable7 = table2.DefaultView.ToTable();
        DataTable table3 = dataTable8.DefaultView.ToTable();
        table3.DefaultView.Sort = "f desc, c asc, a desc";
        dataTable8 = table3.DefaultView.ToTable();
        foreach (DataRow row1 in (InternalDataCollectionBase) dataTable7.Rows)
        {
          foreach (DataRow row2 in (InternalDataCollectionBase) dataTable8.Rows)
          {
            num2 = 0;
            int num3 = Math.Min(Convert.ToInt32(row1["d"]), Convert.ToInt32(row2["e"]) * -1);
            if (num3 > 0)
            {
              DataRow row3 = table1.NewRow();
              row3.BeginEdit();
              row3["ID"] = (object) num1;
              row3["SKU_SIZE"] = row1["SKU_SIZE"];
              row3["I_REGIONAL_RESERVE"] = row2["RESERVES"];
              row3["RESERVES"] = row1["RESERVES"];
              row3["g"] = (object) num3;
              table1.Rows.Add(row3);
              row3.EndEdit();
              ++num1;
              DataRow row4 = table1.NewRow();
              row4.BeginEdit();
              row4["ID"] = (object) num1;
              row4["SKU_SIZE"] = row2["SKU_SIZE"];
              row4["I_REGIONAL_RESERVE"] = row1["RESERVES"];
              row4["RESERVES"] = row2["RESERVES"];
              row4["h"] = (object) -num3;
              table1.Rows.Add(row4);
              row4.EndEdit();
              ++num1;
              row1.BeginEdit();
              row1["d"] = (object) (Convert.ToInt32(row1["d"]) - num3);
              row1.EndEdit();
              row2.BeginEdit();
              row2["e"] = (object) (Convert.ToInt32(row2["e"]) + num3);
              row2.EndEdit();
            }
          }
        }
      }
    }

    private static void reserve_rebalance_oth(DataSet _DataSet, string _TargetDataTableName)
    {
      DataTable table1 = _DataSet.Tables[_TargetDataTableName];
      DataTable dataTable1 = new DataTable();
      DataTable dataTable2 = new DataTable();
      DataTable dataTable3 = new DataTable();
      DataTable dataTable4 = ((IEnumerable<DataRow>) table1.Select("a>0 and (d>0 or e<0)")).CopyToDataTable<DataRow>();
      table1.Rows.Clear();
      DataTable dataTable5 = ((IEnumerable<DataRow>) dataTable4.Select("d>0")).CopyToDataTable<DataRow>();
      DataTable dataTable6 = ((IEnumerable<DataRow>) dataTable4.Select("e<0")).CopyToDataTable<DataRow>();
      DataTable dataTable7 = dataTable5.Clone();
      DataTable dataTable8 = dataTable6.Clone();
      int num1 = 0;
      int num2 = 0;
      List<string> list1 = dataTable5.AsEnumerable().Select<DataRow, string>((System.Func<DataRow, string>) (SKU_SIZE => SKU_SIZE[nameof (SKU_SIZE)].ToString())).Distinct<string>().ToList<string>();
      List<string> list2 = dataTable6.AsEnumerable().Select<DataRow, string>((System.Func<DataRow, string>) (SKU_SIZE => SKU_SIZE[nameof (SKU_SIZE)].ToString())).Distinct<string>().ToList<string>();
      List<string> stringList = new List<string>();
      foreach (string str1 in list1)
      {
        foreach (string str2 in list2)
        {
          if (str1 == str2)
            stringList.Add(str1);
        }
      }
      foreach (string str in stringList)
      {
        dataTable7.Clear();
        dataTable8.Clear();
        if (((IEnumerable<DataRow>) dataTable5.Select("SKU_SIZE='" + str + "'")).Count<DataRow>() > 0)
          dataTable7 = ((IEnumerable<DataRow>) dataTable5.Select("SKU_SIZE='" + str + "'")).CopyToDataTable<DataRow>();
        if (((IEnumerable<DataRow>) dataTable6.Select("SKU_SIZE='" + str + "'")).Count<DataRow>() > 0)
          dataTable8 = ((IEnumerable<DataRow>) dataTable6.Select("SKU_SIZE='" + str + "'")).CopyToDataTable<DataRow>();
        DataTable table2 = dataTable7.DefaultView.ToTable();
        table2.DefaultView.Sort = "b asc, a asc";
        dataTable7 = table2.DefaultView.ToTable();
        DataTable table3 = dataTable8.DefaultView.ToTable();
        table3.DefaultView.Sort = "f desc, c asc, a desc";
        dataTable8 = table3.DefaultView.ToTable();
        foreach (DataRow row1 in (InternalDataCollectionBase) dataTable7.Rows)
        {
          foreach (DataRow row2 in (InternalDataCollectionBase) dataTable8.Rows)
          {
            num2 = 0;
            int num3 = Math.Min(Convert.ToInt32(row1["d"]), Convert.ToInt32(row2["e"]) * -1);
            if (num3 > 0)
            {
              DataRow row3 = table1.NewRow();
              row3.BeginEdit();
              row3["ID"] = (object) num1;
              row3["SKU_SIZE"] = row1["SKU_SIZE"];
              row3["I_REGIONAL_RESERVE"] = row2["RESERVES"];
              row3["RESERVES"] = row1["RESERVES"];
              row3["g"] = (object) num3;
              table1.Rows.Add(row3);
              row3.EndEdit();
              ++num1;
              DataRow row4 = table1.NewRow();
              row4.BeginEdit();
              row4["ID"] = (object) num1;
              row4["SKU_SIZE"] = row2["SKU_SIZE"];
              row4["I_REGIONAL_RESERVE"] = row1["RESERVES"];
              row4["RESERVES"] = row2["RESERVES"];
              row4["h"] = (object) -num3;
              table1.Rows.Add(row4);
              row4.EndEdit();
              ++num1;
              row1.BeginEdit();
              row1["d"] = (object) (Convert.ToInt32(row1["d"]) - num3);
              row1.EndEdit();
              row2.BeginEdit();
              row2["e"] = (object) (Convert.ToInt32(row2["e"]) + num3);
              row2.EndEdit();
            }
          }
        }
      }
    }

    private static void central_rblres_wohsubs(DataSet _DataSet, string _TargetDataTableName)
    {
      DataTable table1 = _DataSet.Tables[_TargetDataTableName];
      DataTable dataTable1 = new DataTable();
      DataTable dataTable2 = ((IEnumerable<DataRow>) table1.Select("a>0 and (e>0 or f<0) and j=0")).CopyToDataTable<DataRow>();
      table1.Rows.Clear();
      dataTable2.Columns.Add(new DataColumn("SKU_GEO", typeof (string)));
      dataTable2.Columns.Add(new DataColumn("NEED", typeof (int)));
      foreach (DataRow row in (InternalDataCollectionBase) dataTable2.Rows)
      {
        row["SKU_GEO"] = (object) Convert.ToString(row["SKU_SIZE"]);
        row["NEED"] = Convert.ToInt32(row["e"]) <= 0 ? (object) Convert.ToInt32(row["f"]) : (object) Convert.ToInt32(row["e"]);
      }
      dataTable2.Clone();
      dataTable2.Clone();
      DataTable dataTable3 = dataTable2.Clone();
      DataTable dataTable4 = dataTable2.Clone();
      int num1 = 0;
      DataTable dataTable5 = ((IEnumerable<DataRow>) dataTable2.Select("NEED>0")).CopyToDataTable<DataRow>();
      DataTable dataTable6 = ((IEnumerable<DataRow>) dataTable2.Select("NEED<0")).CopyToDataTable<DataRow>();
      foreach (object obj in dataTable5.AsEnumerable().Select<DataRow, string>((System.Func<DataRow, string>) (SKU_SIZE => SKU_SIZE[nameof (SKU_SIZE)].ToString())).Distinct<string>().ToList<string>())
      {
        string str = obj.ToString();
        dataTable3.Rows.Clear();
        dataTable4.Rows.Clear();
        if (((IEnumerable<DataRow>) dataTable5.Select("SKU_SIZE='" + str + "'")).Count<DataRow>() > 0)
          dataTable3 = ((IEnumerable<DataRow>) dataTable5.Select("SKU_SIZE='" + str + "'")).CopyToDataTable<DataRow>();
        if (((IEnumerable<DataRow>) dataTable6.Select("SKU_SIZE='" + str + "'")).Count<DataRow>() > 0)
          dataTable4 = ((IEnumerable<DataRow>) dataTable6.Select("SKU_SIZE='" + str + "'")).CopyToDataTable<DataRow>();
        DataTable table2 = dataTable3.DefaultView.ToTable();
        table2.DefaultView.Sort = "i desc, a asc";
        dataTable3 = table2.DefaultView.ToTable();
        DataTable table3 = dataTable4.DefaultView.ToTable();
        table3.DefaultView.Sort = "k asc, i asc, a desc";
        dataTable4 = table3.DefaultView.ToTable();
        foreach (DataRow row1 in (InternalDataCollectionBase) dataTable3.Rows)
        {
          foreach (DataRow row2 in (InternalDataCollectionBase) dataTable4.Rows)
          {
            if (Convert.ToInt32(row1["NEED"]) > 0 && Convert.ToInt32(row2["NEED"]) < 0)
            {
              int num2 = Math.Min(Convert.ToInt32(row1["NEED"]), Convert.ToInt32(row2["NEED"]) * -1);
              if (num2 > 0)
              {
                ++num1;
                DataRow row3 = table1.NewRow();
                row3["ID"] = (object) num1;
                row3["SKU_SIZE"] = row1["SKU_SIZE"];
                row3["RESERVES"] = row1["RESERVES"];
                row3["RESERVES_SA"] = row2["RESERVES_SA"];
                row3["l"] = (object) num2;
                table1.Rows.Add(row3);
                ++num1;
                DataRow row4 = table1.NewRow();
                row4["ID"] = (object) num1;
                row4["SKU_SIZE"] = row2["SKU_SIZE"];
                row4["RESERVES"] = row2["RESERVES"];
                row4["RESERVES_SA"] = row1["RESERVES_SA"];
                row4["m"] = (object) -num2;
                table1.Rows.Add(row4);
                row2.BeginEdit();
                row1.BeginEdit();
                row1["NEED"] = (object) (Convert.ToInt32(row1["NEED"]) - num2);
                row2["NEED"] = (object) (Convert.ToInt32(row2["NEED"]) + num2);
                row2.EndEdit();
                row1.EndEdit();
              }
            }
          }
        }
      }
    }

    private static void central_rblres_fixed_priority(DataSet _DataSet, string _TargetDataTableName)
    {
      DataTable table1 = _DataSet.Tables[_TargetDataTableName];
      DataTable dataTable1 = new DataTable();
      DataTable dataTable2 = new DataTable();
      DataTable dataTable3 = new DataTable();
      DataTable dataTable4 = ((IEnumerable<DataRow>) table1.Select("a>0 and (d>0 or e<0)")).CopyToDataTable<DataRow>();
      table1.Rows.Clear();
      DataTable dataTable5 = ((IEnumerable<DataRow>) dataTable4.Select("d>0")).CopyToDataTable<DataRow>();
      DataTable dataTable6 = ((IEnumerable<DataRow>) dataTable4.Select("e<0")).CopyToDataTable<DataRow>();
      DataTable dataTable7 = dataTable5.Clone();
      DataTable dataTable8 = dataTable6.Clone();
      int num1 = 0;
      int num2 = 0;
      List<string> list1 = dataTable5.AsEnumerable().Select<DataRow, string>((System.Func<DataRow, string>) (SKU_SIZE => SKU_SIZE[nameof (SKU_SIZE)].ToString())).Distinct<string>().ToList<string>();
      List<string> list2 = dataTable6.AsEnumerable().Select<DataRow, string>((System.Func<DataRow, string>) (SKU_SIZE => SKU_SIZE[nameof (SKU_SIZE)].ToString())).Distinct<string>().ToList<string>();
      List<string> stringList = new List<string>();
      foreach (string str1 in list1)
      {
        foreach (string str2 in list2)
        {
          if (str1 == str2)
            stringList.Add(str1);
        }
      }
      foreach (string str in stringList)
      {
        dataTable7.Clear();
        dataTable8.Clear();
        if (((IEnumerable<DataRow>) dataTable5.Select("SKU_SIZE='" + str + "'")).Count<DataRow>() > 0)
          dataTable7 = ((IEnumerable<DataRow>) dataTable5.Select("SKU_SIZE='" + str + "'")).CopyToDataTable<DataRow>();
        if (((IEnumerable<DataRow>) dataTable6.Select("SKU_SIZE='" + str + "'")).Count<DataRow>() > 0)
          dataTable8 = ((IEnumerable<DataRow>) dataTable6.Select("SKU_SIZE='" + str + "'")).CopyToDataTable<DataRow>();
        DataTable table2 = dataTable7.DefaultView.ToTable();
        table2.DefaultView.Sort = "a asc";
        dataTable7 = table2.DefaultView.ToTable();
        DataTable table3 = dataTable8.DefaultView.ToTable();
        table3.DefaultView.Sort = "a desc";
        dataTable8 = table3.DefaultView.ToTable();
        foreach (DataRow row1 in (InternalDataCollectionBase) dataTable7.Rows)
        {
          foreach (DataRow row2 in (InternalDataCollectionBase) dataTable8.Rows)
          {
            num2 = 0;
            int num3 = Math.Min(Convert.ToInt32(row1["d"]), Convert.ToInt32(row2["e"]) * -1);
            if (num3 > 0)
            {
              DataRow row3 = table1.NewRow();
              row3.BeginEdit();
              row3["ID"] = (object) num1;
              row3["SKU_SIZE"] = row1["SKU_SIZE"];
              row3["I_REGIONAL_RESERVE"] = row2["RESERVES"];
              row3["RESERVES"] = row1["RESERVES"];
              row3["g"] = (object) num3;
              table1.Rows.Add(row3);
              row3.EndEdit();
              ++num1;
              DataRow row4 = table1.NewRow();
              row4.BeginEdit();
              row4["ID"] = (object) num1;
              row4["SKU_SIZE"] = row2["SKU_SIZE"];
              row4["I_REGIONAL_RESERVE"] = row1["RESERVES"];
              row4["RESERVES"] = row2["RESERVES"];
              row4["h"] = (object) -num3;
              table1.Rows.Add(row4);
              row4.EndEdit();
              ++num1;
              row1.BeginEdit();
              row1["d"] = (object) (Convert.ToInt32(row1["d"]) - num3);
              row1.EndEdit();
              row2.BeginEdit();
              row2["e"] = (object) (Convert.ToInt32(row2["e"]) + num3);
              row2.EndEdit();
            }
          }
        }
      }
    }
  }
}
