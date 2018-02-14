using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class User
    {
        #region Fields
        private ICollection<Claim> _claims;
        private ICollection<ExternalLogin> _externalLogins;
        private ICollection<Role> _roles;
        #endregion

        #region Scalar Properties

        //
        // Summary:
        //     User ID (Primary Key)
        public virtual Guid UserId { get; set; }
        //
        // Summary:
        //     User name
        public virtual string UserName { get; set; }
        //
        // Summary:
        //     The salted/hashed form of the user password
        public virtual string PasswordHash { get; set; }
        //
        // Summary:
        //     A random value that should change whenever a users credentials have changed (password
        //     changed, login removed)
        public virtual string SecurityStamp { get; set; }


        public virtual string Email { get; set; }
        //
        // Summary:
        //     True if the email is confirmed, default is false
        public virtual bool EmailConfirmed { get; set; }
        //
        // Summary:
        //     Is lockout enabled for this user
        public virtual bool LockoutEnabled { get; set; }
        //
        // Summary:
        //     DateTime in UTC when lockout ends, any time in the past is considered not locked
        //     out.
        public virtual DateTime? LockoutEndDateUtc { get; set; }
        //
        // Summary:
        //     Used to record failures for the purposes of lockout
        public virtual int AccessFailedCount { get; set; }
        //
        // Summary:
        //     PhoneNumber for the user
        public virtual string PhoneNumber { get; set; }
        //
        // Summary:
        //     True if the phone number is confirmed, default is false
        public virtual bool PhoneNumberConfirmed { get; set; }
        //
        // Summary:
        //     Is two factor enabled for the user
        public virtual bool TwoFactorEnabled { get; set; }
        #endregion

        #region Navigation Properties

        //
        // Summary:
        //     Navigation property for user claims
        public virtual ICollection<Claim> Claims
        {
            get { return _claims ?? (_claims = new List<Claim>()); }
            set { _claims = value; }
        }

        //
        // Summary:
        //     Navigation property for user logins
        public virtual ICollection<ExternalLogin> Logins
        {
            get
            {
                return _externalLogins ??
                    (_externalLogins = new List<ExternalLogin>());
            }
            set { _externalLogins = value; }
        }

        //
        // Summary:
        //     Navigation property for user roles
        public virtual ICollection<Role> Roles
        {
            get { return _roles ?? (_roles = new List<Role>()); }
            set { _roles = value; }
        }
        #endregion
    }
}