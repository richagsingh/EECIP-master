
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace EECIP.App_Logic.DataAccessLayer
{

using System;
    using System.Collections.Generic;
    
public partial class T_OE_PROJECT_VOTES
{

    public System.Guid PROJECT_VOTE_IDX { get; set; }

    public int VOTE_AMOUNT { get; set; }

    public Nullable<System.DateTime> DATE_VOTED { get; set; }

    public Nullable<System.Guid> PROJECT_IDX { get; set; }

    public Nullable<int> ORG_ENT_SVCS_IDX { get; set; }

    public Nullable<int> VOTED_BY_USER_IDX { get; set; }



    public virtual T_OE_ORGANIZATION_ENT_SVCS T_OE_ORGANIZATION_ENT_SVCS { get; set; }

    public virtual T_OE_PROJECTS T_OE_PROJECTS { get; set; }

    public virtual T_OE_USERS T_OE_USERS { get; set; }

}

}
