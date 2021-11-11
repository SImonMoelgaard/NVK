using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    class HL7FHIRModel
    {

        public class Patient
        {
            public string resourceType { get; set; }
            public string id { get; set; }
            public Meta meta { get; set; }
            public string type { get; set; }
            public Link[] link { get; set; }
            public Entry[] entry { get; set; }
        }

        public class Meta
        {
            public DateTime lastUpdated { get; set; }
        }

        public class Link
        {
            public string relation { get; set; }
            public string url { get; set; }
        }

        public class Entry
        {
            public string fullUrl { get; set; }
            public Resource resource { get; set; }
            public Search search { get; set; }
        }

        public class Resource
        {
            public string resourceType { get; set; }
            public string id { get; set; }
            public Meta1 meta { get; set; }
            public bool active { get; set; }
            public List<Name> name { get; set; }
            
            public string gender { get; set; }
            public string birthDate { get; set; }
            public List<Extension> extension { get; set; }
            
            public Identifier[] identifier { get; set; }
            public Telecom[] telecom { get; set; }
            public _Birthdate _birthDate { get; set; }
            public bool deceasedBoolean { get; set; }
            public Address[] address { get; set; }
            public Contact[] contact { get; set; }
            public Text text { get; set; }
            public string status { get; set; }
            public Category[] category { get; set; }
            public Code code { get; set; }
            public Subject subject { get; set; }
            public DateTime effectiveDateTime { get; set; }
            public Performer[] performer { get; set; }
            public Device device { get; set; }
            public Component[] component { get; set; }
        }

        public class Meta1
        {
            public string versionId { get; set; }
            public DateTime lastUpdated { get; set; }
        }

        public class _Birthdate
        {
            public Extension[] extension { get; set; }
        }

        public class Extension
        {
            public string url { get; set; }
            public DateTime valueDateTime { get; set; }
            public Valueaddress valueAddress { get; set; }
        }

        public class Text
        {
            public string status { get; set; }
            public string div { get; set; }
        }

        public class Code
        {
            public Coding[] coding { get; set; }
        }

        public class Coding
        {
            public string system { get; set; }
            public string code { get; set; }
            public string display { get; set; }
        }

        public class Subject
        {
            public string reference { get; set; }
            public string display { get; set; }
        }

        public class Device
        {
            public string display { get; set; }
        }

        public class Name
        {
            public string use { get; set; }
            public string family { get; set; }
            public string[] given { get; set; }
            public string[] prefix { get; set; }
        }

        //public class Extension1
        //{
          //  public string url { get; set; }
            //public Valueaddress valueAddress { get; set; }
        //}

        public class Valueaddress
        {
            public string city { get; set; }
        }

        public class Identifier
        {
            public string system { get; set; }
            public string value { get; set; }
        }

        public class Telecom
        {
            public string system { get; set; }
            public string value { get; set; }
            public string use { get; set; }
            public int rank { get; set; }
            public Period period { get; set; }
        }

        public class Period
        {
            public string end { get; set; }
        }

        public class Address
        {
            public string[] line { get; set; }
            public string city { get; set; }
            public string state { get; set; }
            public string postalCode { get; set; }
            public string country { get; set; }
        }

        public class Contact
        {
            public Relationship[] relationship { get; set; }
            public Name1 name { get; set; }
            public Telecom1[] telecom { get; set; }
            public string gender { get; set; }
        }

        public class Name1
        {
            public string family { get; set; }
            public string[] given { get; set; }
        }

        public class Relationship
        {
            public Coding1[] coding { get; set; }
        }

        public class Coding1
        {
            public string system { get; set; }
            public string code { get; set; }
        }

        public class Telecom1
        {
            public string system { get; set; }
            public string value { get; set; }
            public string use { get; set; }
        }

        public class Category
        {
            public Coding2[] coding { get; set; }
        }

        public class Coding2
        {
            public string system { get; set; }
            public string code { get; set; }
            public string display { get; set; }
        }

        public class Performer
        {
            public string reference { get; set; }
            public string display { get; set; }
        }

        public class Component
        {
            public Code1 code { get; set; }
            public Valuesampleddata valueSampledData { get; set; }
        }

        public class Code1
        {
            public Coding3[] coding { get; set; }
        }

        public class Coding3
        {
            public string system { get; set; }
            public string code { get; set; }
            public string display { get; set; }
        }

        public class Valuesampleddata
        {
            public Origin origin { get; set; }
            public float period { get; set; }
            public float factor { get; set; }
            public float lowerLimit { get; set; }
            public float upperLimit { get; set; }
            public int dimensions { get; set; }
            public string data { get; set; }
        }

        public class Origin
        {
            public float value { get; set; }
        }

        public class Search
        {
            public string mode { get; set; }
        }

    }
}
