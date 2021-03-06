
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
    
public partial class Topic
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Topic()
    {

        this.Posts = new HashSet<Post>();

        this.Favourites = new HashSet<Favourite>();

        this.Topic_Tags = new HashSet<Topic_Tags>();

        this.TopicNotifications = new HashSet<TopicNotification>();

    }


    public System.Guid Id { get; set; }

    public string Name { get; set; }

    public System.DateTime CreateDate { get; set; }

    public bool Solved { get; set; }

    public Nullable<bool> SolvedReminderSent { get; set; }

    public string Slug { get; set; }

    public Nullable<int> Views { get; set; }

    public bool IsSticky { get; set; }

    public bool IsLocked { get; set; }

    public Nullable<bool> Pending { get; set; }

    public System.Guid Category_Id { get; set; }

    public Nullable<System.Guid> Post_Id { get; set; }

    public Nullable<System.Guid> Poll_Id { get; set; }

    public int MembershipUser_Id { get; set; }

    public bool SYNC_IND { get; set; }



    public virtual T_OE_USERS T_OE_USERS { get; set; }

    public virtual Category Category { get; set; }

    public virtual Poll Poll { get; set; }

    public virtual Post Post { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Post> Posts { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Favourite> Favourites { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Topic_Tags> Topic_Tags { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<TopicNotification> TopicNotifications { get; set; }

}

}
