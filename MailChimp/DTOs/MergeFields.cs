using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace MailChimp.DTOs
{
    /// <summary>
    /// Member Merge Vars
    /// https://us11.api.mailchimp.com/schema/3.0/Lists/Members/MergeField.json
    /// </summary>
    [DataContract]
    public class MergeFields: Dictionary<string, object>
    {
        public enum DefaultVarNames
        {
            FNAME,
            LNAME
        }

        public string FirstNameVarName { get; private set; }
        public string LastNameVarName { get; private set; }

        public MergeFields()
        {
            FirstNameVarName = DefaultVarNames.FNAME.ToString();
            LastNameVarName = DefaultVarNames.LNAME.ToString();
        }

        public MergeFields(string firstNameVarName, string lastNameVarName)
        {
            FirstNameVarName = firstNameVarName;
            LastNameVarName = lastNameVarName;
        }

        public virtual void AddOrUpdateVar(string varName, object value)
        {
            if (Keys.Contains(varName))
            {
                this[varName] = value;
            }
            else
            {
                Add(varName, value);
            }
        }

        [JsonIgnoreAttribute]
        public string FirstName
        {
            get
            {
                if (Keys.Contains(FirstNameVarName))
                {
                    return this[FirstNameVarName].ToString();
                }
                return null;
            }
            set
            {
                AddOrUpdateVar(FirstNameVarName, value);
            }
        }

        [JsonIgnoreAttribute]
        public string LastName
        {
            get
            {
                if (Keys.Contains(LastNameVarName))
                {
                    return this[LastNameVarName].ToString();
                }
                return null;
            }
            set
            {
                AddOrUpdateVar(LastNameVarName, value);
            }
        }
    }
}