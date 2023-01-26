using System;

namespace librery { };
/// <summary>
/// کلاس انتخاب کتاب
/// </summary>

public class Program : Object
{
    #region constructor 
    /// <summary>
    /// انتخاب
    /// </summary>
    /// <param name="zhanr">ژانر کتاب</param>
    /// <param name="nevisandeh">نویسنده</param>
    public Program(string zhanr, string nevisandeh) : base()
    {
        
        this.zhanr = zhanr;
        this.nevisandeh = nevisandeh;
    }
    #endregion /constructor

    #region properties

    #region public int? sal_sakht { get; set; }
    /// <summary>
    /// سال ساخت
    /// </summary>
    public int? sal_sakht { get; set; }
    #endregion /public int? sal_sakht { get; set; }

    #region public string zhanr { get; set; }
    /// <summary>
    /// ژانر
    /// </summary>
    public string zhanr { get; set; }
    #endregion /public string zhanr { get; set; }

    #region public string nevisandeh { get; set; }
    /// <summary>
    /// نویسنده
    /// </summary>
    public string nevisandeh { get; set; }
    #endregion /public string nevisandeh { get; set; }

    #endregion properties

}