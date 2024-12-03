/*
 * OneSignal
 *
 * A powerful way to send personalized messages at scale and build effective customer engagement strategies. Learn more at onesignal.com
 *
 * The version of the OpenAPI document: 1.3.0
 * Contact: devrel@onesignal.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = OneSignalApi.Client.OpenAPIDateConverter;

namespace OneSignalApi.Model
{
    /// <summary>
    /// StringMap
    /// </summary>
    [DataContract(Name = "StringMap")]
    public partial class StringMap : IEquatable<StringMap>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StringMap" /> class.
        /// </summary>
        /// <param name="en">Text in English.  Will be used as a fallback.</param>
        /// <param name="ar">Text in Arabic..</param>
        /// <param name="bs">Text in Bosnian..</param>
        /// <param name="bg">Text in Bulgarian..</param>
        /// <param name="ca">Text in Catalan..</param>
        /// <param name="zhHans">Text in Chinese (Simplified)..</param>
        /// <param name="zhHant">Text in Chinese (Traditional)..</param>
        /// <param name="zh">Alias for zh-Hans..</param>
        /// <param name="hr">Text in Croatian..</param>
        /// <param name="cs">Text in Czech..</param>
        /// <param name="da">Text in Danish..</param>
        /// <param name="nl">Text in Dutch..</param>
        /// <param name="et">Text in Estonian..</param>
        /// <param name="fi">Text in Finnish..</param>
        /// <param name="fr">Text in French..</param>
        /// <param name="ka">Text in Georgian..</param>
        /// <param name="de">Text in German..</param>
        /// <param name="el">Text in Greek..</param>
        /// <param name="hi">Text in Hindi..</param>
        /// <param name="he">Text in Hebrew..</param>
        /// <param name="hu">Text in Hungarian..</param>
        /// <param name="id">Text in Indonesian..</param>
        /// <param name="it">Text in Italian..</param>
        /// <param name="ja">Text in Japanese..</param>
        /// <param name="ko">Text in Korean..</param>
        /// <param name="lv">Text in Latvian..</param>
        /// <param name="lt">Text in Lithuanian..</param>
        /// <param name="ms">Text in Malay..</param>
        /// <param name="nb">Text in Norwegian..</param>
        /// <param name="pl">Text in Polish..</param>
        /// <param name="fa">Text in Persian..</param>
        /// <param name="pt">Text in Portugese..</param>
        /// <param name="pa">Text in Punjabi..</param>
        /// <param name="ro">Text in Romanian..</param>
        /// <param name="ru">Text in Russian..</param>
        /// <param name="sr">Text in Serbian..</param>
        /// <param name="sk">Text in Slovak..</param>
        /// <param name="es">Text in Spanish..</param>
        /// <param name="sv">Text in Swedish..</param>
        /// <param name="th">Text in Thai..</param>
        /// <param name="tr">Text in Turkish..</param>
        /// <param name="uk">Text in Ukrainian..</param>
        /// <param name="vi">Text in Vietnamese..</param>
        public StringMap(string en = default(string), string ar = default(string), string bs = default(string), string bg = default(string), string ca = default(string), string zhHans = default(string), string zhHant = default(string), string zh = default(string), string hr = default(string), string cs = default(string), string da = default(string), string nl = default(string), string et = default(string), string fi = default(string), string fr = default(string), string ka = default(string), string de = default(string), string el = default(string), string hi = default(string), string he = default(string), string hu = default(string), string id = default(string), string it = default(string), string ja = default(string), string ko = default(string), string lv = default(string), string lt = default(string), string ms = default(string), string nb = default(string), string pl = default(string), string fa = default(string), string pt = default(string), string pa = default(string), string ro = default(string), string ru = default(string), string sr = default(string), string sk = default(string), string es = default(string), string sv = default(string), string th = default(string), string tr = default(string), string uk = default(string), string vi = default(string))
        {
            this.En = en;
            this.Ar = ar;
            this.Bs = bs;
            this.Bg = bg;
            this.Ca = ca;
            this.ZhHans = zhHans;
            this.ZhHant = zhHant;
            this.Zh = zh;
            this.Hr = hr;
            this.Cs = cs;
            this.Da = da;
            this.Nl = nl;
            this.Et = et;
            this.Fi = fi;
            this.Fr = fr;
            this.Ka = ka;
            this.De = de;
            this.El = el;
            this.Hi = hi;
            this.He = he;
            this.Hu = hu;
            this.Id = id;
            this.It = it;
            this.Ja = ja;
            this.Ko = ko;
            this.Lv = lv;
            this.Lt = lt;
            this.Ms = ms;
            this.Nb = nb;
            this.Pl = pl;
            this.Fa = fa;
            this.Pt = pt;
            this.Pa = pa;
            this.Ro = ro;
            this.Ru = ru;
            this.Sr = sr;
            this.Sk = sk;
            this.Es = es;
            this.Sv = sv;
            this.Th = th;
            this.Tr = tr;
            this.Uk = uk;
            this.Vi = vi;
        }

        /// <summary>
        /// Text in English.  Will be used as a fallback
        /// </summary>
        /// <value>Text in English.  Will be used as a fallback</value>
        [DataMember(Name = "en", EmitDefaultValue = false)]
        public string En { get; set; }

        /// <summary>
        /// Text in Arabic.
        /// </summary>
        /// <value>Text in Arabic.</value>
        [DataMember(Name = "ar", EmitDefaultValue = false)]
        public string Ar { get; set; }

        /// <summary>
        /// Text in Bosnian.
        /// </summary>
        /// <value>Text in Bosnian.</value>
        [DataMember(Name = "bs", EmitDefaultValue = false)]
        public string Bs { get; set; }

        /// <summary>
        /// Text in Bulgarian.
        /// </summary>
        /// <value>Text in Bulgarian.</value>
        [DataMember(Name = "bg", EmitDefaultValue = false)]
        public string Bg { get; set; }

        /// <summary>
        /// Text in Catalan.
        /// </summary>
        /// <value>Text in Catalan.</value>
        [DataMember(Name = "ca", EmitDefaultValue = false)]
        public string Ca { get; set; }

        /// <summary>
        /// Text in Chinese (Simplified).
        /// </summary>
        /// <value>Text in Chinese (Simplified).</value>
        [DataMember(Name = "zh-Hans", EmitDefaultValue = false)]
        public string ZhHans { get; set; }

        /// <summary>
        /// Text in Chinese (Traditional).
        /// </summary>
        /// <value>Text in Chinese (Traditional).</value>
        [DataMember(Name = "zh-Hant", EmitDefaultValue = false)]
        public string ZhHant { get; set; }

        /// <summary>
        /// Alias for zh-Hans.
        /// </summary>
        /// <value>Alias for zh-Hans.</value>
        [DataMember(Name = "zh", EmitDefaultValue = false)]
        public string Zh { get; set; }

        /// <summary>
        /// Text in Croatian.
        /// </summary>
        /// <value>Text in Croatian.</value>
        [DataMember(Name = "hr", EmitDefaultValue = false)]
        public string Hr { get; set; }

        /// <summary>
        /// Text in Czech.
        /// </summary>
        /// <value>Text in Czech.</value>
        [DataMember(Name = "cs", EmitDefaultValue = false)]
        public string Cs { get; set; }

        /// <summary>
        /// Text in Danish.
        /// </summary>
        /// <value>Text in Danish.</value>
        [DataMember(Name = "da", EmitDefaultValue = false)]
        public string Da { get; set; }

        /// <summary>
        /// Text in Dutch.
        /// </summary>
        /// <value>Text in Dutch.</value>
        [DataMember(Name = "nl", EmitDefaultValue = false)]
        public string Nl { get; set; }

        /// <summary>
        /// Text in Estonian.
        /// </summary>
        /// <value>Text in Estonian.</value>
        [DataMember(Name = "et", EmitDefaultValue = false)]
        public string Et { get; set; }

        /// <summary>
        /// Text in Finnish.
        /// </summary>
        /// <value>Text in Finnish.</value>
        [DataMember(Name = "fi", EmitDefaultValue = false)]
        public string Fi { get; set; }

        /// <summary>
        /// Text in French.
        /// </summary>
        /// <value>Text in French.</value>
        [DataMember(Name = "fr", EmitDefaultValue = false)]
        public string Fr { get; set; }

        /// <summary>
        /// Text in Georgian.
        /// </summary>
        /// <value>Text in Georgian.</value>
        [DataMember(Name = "ka", EmitDefaultValue = false)]
        public string Ka { get; set; }

        /// <summary>
        /// Text in German.
        /// </summary>
        /// <value>Text in German.</value>
        [DataMember(Name = "de", EmitDefaultValue = false)]
        public string De { get; set; }

        /// <summary>
        /// Text in Greek.
        /// </summary>
        /// <value>Text in Greek.</value>
        [DataMember(Name = "el", EmitDefaultValue = false)]
        public string El { get; set; }

        /// <summary>
        /// Text in Hindi.
        /// </summary>
        /// <value>Text in Hindi.</value>
        [DataMember(Name = "hi", EmitDefaultValue = false)]
        public string Hi { get; set; }

        /// <summary>
        /// Text in Hebrew.
        /// </summary>
        /// <value>Text in Hebrew.</value>
        [DataMember(Name = "he", EmitDefaultValue = false)]
        public string He { get; set; }

        /// <summary>
        /// Text in Hungarian.
        /// </summary>
        /// <value>Text in Hungarian.</value>
        [DataMember(Name = "hu", EmitDefaultValue = false)]
        public string Hu { get; set; }

        /// <summary>
        /// Text in Indonesian.
        /// </summary>
        /// <value>Text in Indonesian.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Text in Italian.
        /// </summary>
        /// <value>Text in Italian.</value>
        [DataMember(Name = "it", EmitDefaultValue = false)]
        public string It { get; set; }

        /// <summary>
        /// Text in Japanese.
        /// </summary>
        /// <value>Text in Japanese.</value>
        [DataMember(Name = "ja", EmitDefaultValue = false)]
        public string Ja { get; set; }

        /// <summary>
        /// Text in Korean.
        /// </summary>
        /// <value>Text in Korean.</value>
        [DataMember(Name = "ko", EmitDefaultValue = false)]
        public string Ko { get; set; }

        /// <summary>
        /// Text in Latvian.
        /// </summary>
        /// <value>Text in Latvian.</value>
        [DataMember(Name = "lv", EmitDefaultValue = false)]
        public string Lv { get; set; }

        /// <summary>
        /// Text in Lithuanian.
        /// </summary>
        /// <value>Text in Lithuanian.</value>
        [DataMember(Name = "lt", EmitDefaultValue = false)]
        public string Lt { get; set; }

        /// <summary>
        /// Text in Malay.
        /// </summary>
        /// <value>Text in Malay.</value>
        [DataMember(Name = "ms", EmitDefaultValue = false)]
        public string Ms { get; set; }

        /// <summary>
        /// Text in Norwegian.
        /// </summary>
        /// <value>Text in Norwegian.</value>
        [DataMember(Name = "nb", EmitDefaultValue = false)]
        public string Nb { get; set; }

        /// <summary>
        /// Text in Polish.
        /// </summary>
        /// <value>Text in Polish.</value>
        [DataMember(Name = "pl", EmitDefaultValue = false)]
        public string Pl { get; set; }

        /// <summary>
        /// Text in Persian.
        /// </summary>
        /// <value>Text in Persian.</value>
        [DataMember(Name = "fa", EmitDefaultValue = false)]
        public string Fa { get; set; }

        /// <summary>
        /// Text in Portugese.
        /// </summary>
        /// <value>Text in Portugese.</value>
        [DataMember(Name = "pt", EmitDefaultValue = false)]
        public string Pt { get; set; }

        /// <summary>
        /// Text in Punjabi.
        /// </summary>
        /// <value>Text in Punjabi.</value>
        [DataMember(Name = "pa", EmitDefaultValue = false)]
        public string Pa { get; set; }

        /// <summary>
        /// Text in Romanian.
        /// </summary>
        /// <value>Text in Romanian.</value>
        [DataMember(Name = "ro", EmitDefaultValue = false)]
        public string Ro { get; set; }

        /// <summary>
        /// Text in Russian.
        /// </summary>
        /// <value>Text in Russian.</value>
        [DataMember(Name = "ru", EmitDefaultValue = false)]
        public string Ru { get; set; }

        /// <summary>
        /// Text in Serbian.
        /// </summary>
        /// <value>Text in Serbian.</value>
        [DataMember(Name = "sr", EmitDefaultValue = false)]
        public string Sr { get; set; }

        /// <summary>
        /// Text in Slovak.
        /// </summary>
        /// <value>Text in Slovak.</value>
        [DataMember(Name = "sk", EmitDefaultValue = false)]
        public string Sk { get; set; }

        /// <summary>
        /// Text in Spanish.
        /// </summary>
        /// <value>Text in Spanish.</value>
        [DataMember(Name = "es", EmitDefaultValue = false)]
        public string Es { get; set; }

        /// <summary>
        /// Text in Swedish.
        /// </summary>
        /// <value>Text in Swedish.</value>
        [DataMember(Name = "sv", EmitDefaultValue = false)]
        public string Sv { get; set; }

        /// <summary>
        /// Text in Thai.
        /// </summary>
        /// <value>Text in Thai.</value>
        [DataMember(Name = "th", EmitDefaultValue = false)]
        public string Th { get; set; }

        /// <summary>
        /// Text in Turkish.
        /// </summary>
        /// <value>Text in Turkish.</value>
        [DataMember(Name = "tr", EmitDefaultValue = false)]
        public string Tr { get; set; }

        /// <summary>
        /// Text in Ukrainian.
        /// </summary>
        /// <value>Text in Ukrainian.</value>
        [DataMember(Name = "uk", EmitDefaultValue = false)]
        public string Uk { get; set; }

        /// <summary>
        /// Text in Vietnamese.
        /// </summary>
        /// <value>Text in Vietnamese.</value>
        [DataMember(Name = "vi", EmitDefaultValue = false)]
        public string Vi { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StringMap {\n");
            sb.Append("  En: ").Append(En).Append("\n");
            sb.Append("  Ar: ").Append(Ar).Append("\n");
            sb.Append("  Bs: ").Append(Bs).Append("\n");
            sb.Append("  Bg: ").Append(Bg).Append("\n");
            sb.Append("  Ca: ").Append(Ca).Append("\n");
            sb.Append("  ZhHans: ").Append(ZhHans).Append("\n");
            sb.Append("  ZhHant: ").Append(ZhHant).Append("\n");
            sb.Append("  Zh: ").Append(Zh).Append("\n");
            sb.Append("  Hr: ").Append(Hr).Append("\n");
            sb.Append("  Cs: ").Append(Cs).Append("\n");
            sb.Append("  Da: ").Append(Da).Append("\n");
            sb.Append("  Nl: ").Append(Nl).Append("\n");
            sb.Append("  Et: ").Append(Et).Append("\n");
            sb.Append("  Fi: ").Append(Fi).Append("\n");
            sb.Append("  Fr: ").Append(Fr).Append("\n");
            sb.Append("  Ka: ").Append(Ka).Append("\n");
            sb.Append("  De: ").Append(De).Append("\n");
            sb.Append("  El: ").Append(El).Append("\n");
            sb.Append("  Hi: ").Append(Hi).Append("\n");
            sb.Append("  He: ").Append(He).Append("\n");
            sb.Append("  Hu: ").Append(Hu).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  It: ").Append(It).Append("\n");
            sb.Append("  Ja: ").Append(Ja).Append("\n");
            sb.Append("  Ko: ").Append(Ko).Append("\n");
            sb.Append("  Lv: ").Append(Lv).Append("\n");
            sb.Append("  Lt: ").Append(Lt).Append("\n");
            sb.Append("  Ms: ").Append(Ms).Append("\n");
            sb.Append("  Nb: ").Append(Nb).Append("\n");
            sb.Append("  Pl: ").Append(Pl).Append("\n");
            sb.Append("  Fa: ").Append(Fa).Append("\n");
            sb.Append("  Pt: ").Append(Pt).Append("\n");
            sb.Append("  Pa: ").Append(Pa).Append("\n");
            sb.Append("  Ro: ").Append(Ro).Append("\n");
            sb.Append("  Ru: ").Append(Ru).Append("\n");
            sb.Append("  Sr: ").Append(Sr).Append("\n");
            sb.Append("  Sk: ").Append(Sk).Append("\n");
            sb.Append("  Es: ").Append(Es).Append("\n");
            sb.Append("  Sv: ").Append(Sv).Append("\n");
            sb.Append("  Th: ").Append(Th).Append("\n");
            sb.Append("  Tr: ").Append(Tr).Append("\n");
            sb.Append("  Uk: ").Append(Uk).Append("\n");
            sb.Append("  Vi: ").Append(Vi).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as StringMap);
        }

        /// <summary>
        /// Returns true if StringMap instances are equal
        /// </summary>
        /// <param name="input">Instance of StringMap to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StringMap input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.En == input.En ||
                    (this.En != null &&
                    this.En.Equals(input.En))
                ) && 
                (
                    this.Ar == input.Ar ||
                    (this.Ar != null &&
                    this.Ar.Equals(input.Ar))
                ) && 
                (
                    this.Bs == input.Bs ||
                    (this.Bs != null &&
                    this.Bs.Equals(input.Bs))
                ) && 
                (
                    this.Bg == input.Bg ||
                    (this.Bg != null &&
                    this.Bg.Equals(input.Bg))
                ) && 
                (
                    this.Ca == input.Ca ||
                    (this.Ca != null &&
                    this.Ca.Equals(input.Ca))
                ) && 
                (
                    this.ZhHans == input.ZhHans ||
                    (this.ZhHans != null &&
                    this.ZhHans.Equals(input.ZhHans))
                ) && 
                (
                    this.ZhHant == input.ZhHant ||
                    (this.ZhHant != null &&
                    this.ZhHant.Equals(input.ZhHant))
                ) && 
                (
                    this.Zh == input.Zh ||
                    (this.Zh != null &&
                    this.Zh.Equals(input.Zh))
                ) && 
                (
                    this.Hr == input.Hr ||
                    (this.Hr != null &&
                    this.Hr.Equals(input.Hr))
                ) && 
                (
                    this.Cs == input.Cs ||
                    (this.Cs != null &&
                    this.Cs.Equals(input.Cs))
                ) && 
                (
                    this.Da == input.Da ||
                    (this.Da != null &&
                    this.Da.Equals(input.Da))
                ) && 
                (
                    this.Nl == input.Nl ||
                    (this.Nl != null &&
                    this.Nl.Equals(input.Nl))
                ) && 
                (
                    this.Et == input.Et ||
                    (this.Et != null &&
                    this.Et.Equals(input.Et))
                ) && 
                (
                    this.Fi == input.Fi ||
                    (this.Fi != null &&
                    this.Fi.Equals(input.Fi))
                ) && 
                (
                    this.Fr == input.Fr ||
                    (this.Fr != null &&
                    this.Fr.Equals(input.Fr))
                ) && 
                (
                    this.Ka == input.Ka ||
                    (this.Ka != null &&
                    this.Ka.Equals(input.Ka))
                ) && 
                (
                    this.De == input.De ||
                    (this.De != null &&
                    this.De.Equals(input.De))
                ) && 
                (
                    this.El == input.El ||
                    (this.El != null &&
                    this.El.Equals(input.El))
                ) && 
                (
                    this.Hi == input.Hi ||
                    (this.Hi != null &&
                    this.Hi.Equals(input.Hi))
                ) && 
                (
                    this.He == input.He ||
                    (this.He != null &&
                    this.He.Equals(input.He))
                ) && 
                (
                    this.Hu == input.Hu ||
                    (this.Hu != null &&
                    this.Hu.Equals(input.Hu))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.It == input.It ||
                    (this.It != null &&
                    this.It.Equals(input.It))
                ) && 
                (
                    this.Ja == input.Ja ||
                    (this.Ja != null &&
                    this.Ja.Equals(input.Ja))
                ) && 
                (
                    this.Ko == input.Ko ||
                    (this.Ko != null &&
                    this.Ko.Equals(input.Ko))
                ) && 
                (
                    this.Lv == input.Lv ||
                    (this.Lv != null &&
                    this.Lv.Equals(input.Lv))
                ) && 
                (
                    this.Lt == input.Lt ||
                    (this.Lt != null &&
                    this.Lt.Equals(input.Lt))
                ) && 
                (
                    this.Ms == input.Ms ||
                    (this.Ms != null &&
                    this.Ms.Equals(input.Ms))
                ) && 
                (
                    this.Nb == input.Nb ||
                    (this.Nb != null &&
                    this.Nb.Equals(input.Nb))
                ) && 
                (
                    this.Pl == input.Pl ||
                    (this.Pl != null &&
                    this.Pl.Equals(input.Pl))
                ) && 
                (
                    this.Fa == input.Fa ||
                    (this.Fa != null &&
                    this.Fa.Equals(input.Fa))
                ) && 
                (
                    this.Pt == input.Pt ||
                    (this.Pt != null &&
                    this.Pt.Equals(input.Pt))
                ) && 
                (
                    this.Pa == input.Pa ||
                    (this.Pa != null &&
                    this.Pa.Equals(input.Pa))
                ) && 
                (
                    this.Ro == input.Ro ||
                    (this.Ro != null &&
                    this.Ro.Equals(input.Ro))
                ) && 
                (
                    this.Ru == input.Ru ||
                    (this.Ru != null &&
                    this.Ru.Equals(input.Ru))
                ) && 
                (
                    this.Sr == input.Sr ||
                    (this.Sr != null &&
                    this.Sr.Equals(input.Sr))
                ) && 
                (
                    this.Sk == input.Sk ||
                    (this.Sk != null &&
                    this.Sk.Equals(input.Sk))
                ) && 
                (
                    this.Es == input.Es ||
                    (this.Es != null &&
                    this.Es.Equals(input.Es))
                ) && 
                (
                    this.Sv == input.Sv ||
                    (this.Sv != null &&
                    this.Sv.Equals(input.Sv))
                ) && 
                (
                    this.Th == input.Th ||
                    (this.Th != null &&
                    this.Th.Equals(input.Th))
                ) && 
                (
                    this.Tr == input.Tr ||
                    (this.Tr != null &&
                    this.Tr.Equals(input.Tr))
                ) && 
                (
                    this.Uk == input.Uk ||
                    (this.Uk != null &&
                    this.Uk.Equals(input.Uk))
                ) && 
                (
                    this.Vi == input.Vi ||
                    (this.Vi != null &&
                    this.Vi.Equals(input.Vi))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.En != null)
                {
                    hashCode = (hashCode * 59) + this.En.GetHashCode();
                }
                if (this.Ar != null)
                {
                    hashCode = (hashCode * 59) + this.Ar.GetHashCode();
                }
                if (this.Bs != null)
                {
                    hashCode = (hashCode * 59) + this.Bs.GetHashCode();
                }
                if (this.Bg != null)
                {
                    hashCode = (hashCode * 59) + this.Bg.GetHashCode();
                }
                if (this.Ca != null)
                {
                    hashCode = (hashCode * 59) + this.Ca.GetHashCode();
                }
                if (this.ZhHans != null)
                {
                    hashCode = (hashCode * 59) + this.ZhHans.GetHashCode();
                }
                if (this.ZhHant != null)
                {
                    hashCode = (hashCode * 59) + this.ZhHant.GetHashCode();
                }
                if (this.Zh != null)
                {
                    hashCode = (hashCode * 59) + this.Zh.GetHashCode();
                }
                if (this.Hr != null)
                {
                    hashCode = (hashCode * 59) + this.Hr.GetHashCode();
                }
                if (this.Cs != null)
                {
                    hashCode = (hashCode * 59) + this.Cs.GetHashCode();
                }
                if (this.Da != null)
                {
                    hashCode = (hashCode * 59) + this.Da.GetHashCode();
                }
                if (this.Nl != null)
                {
                    hashCode = (hashCode * 59) + this.Nl.GetHashCode();
                }
                if (this.Et != null)
                {
                    hashCode = (hashCode * 59) + this.Et.GetHashCode();
                }
                if (this.Fi != null)
                {
                    hashCode = (hashCode * 59) + this.Fi.GetHashCode();
                }
                if (this.Fr != null)
                {
                    hashCode = (hashCode * 59) + this.Fr.GetHashCode();
                }
                if (this.Ka != null)
                {
                    hashCode = (hashCode * 59) + this.Ka.GetHashCode();
                }
                if (this.De != null)
                {
                    hashCode = (hashCode * 59) + this.De.GetHashCode();
                }
                if (this.El != null)
                {
                    hashCode = (hashCode * 59) + this.El.GetHashCode();
                }
                if (this.Hi != null)
                {
                    hashCode = (hashCode * 59) + this.Hi.GetHashCode();
                }
                if (this.He != null)
                {
                    hashCode = (hashCode * 59) + this.He.GetHashCode();
                }
                if (this.Hu != null)
                {
                    hashCode = (hashCode * 59) + this.Hu.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.It != null)
                {
                    hashCode = (hashCode * 59) + this.It.GetHashCode();
                }
                if (this.Ja != null)
                {
                    hashCode = (hashCode * 59) + this.Ja.GetHashCode();
                }
                if (this.Ko != null)
                {
                    hashCode = (hashCode * 59) + this.Ko.GetHashCode();
                }
                if (this.Lv != null)
                {
                    hashCode = (hashCode * 59) + this.Lv.GetHashCode();
                }
                if (this.Lt != null)
                {
                    hashCode = (hashCode * 59) + this.Lt.GetHashCode();
                }
                if (this.Ms != null)
                {
                    hashCode = (hashCode * 59) + this.Ms.GetHashCode();
                }
                if (this.Nb != null)
                {
                    hashCode = (hashCode * 59) + this.Nb.GetHashCode();
                }
                if (this.Pl != null)
                {
                    hashCode = (hashCode * 59) + this.Pl.GetHashCode();
                }
                if (this.Fa != null)
                {
                    hashCode = (hashCode * 59) + this.Fa.GetHashCode();
                }
                if (this.Pt != null)
                {
                    hashCode = (hashCode * 59) + this.Pt.GetHashCode();
                }
                if (this.Pa != null)
                {
                    hashCode = (hashCode * 59) + this.Pa.GetHashCode();
                }
                if (this.Ro != null)
                {
                    hashCode = (hashCode * 59) + this.Ro.GetHashCode();
                }
                if (this.Ru != null)
                {
                    hashCode = (hashCode * 59) + this.Ru.GetHashCode();
                }
                if (this.Sr != null)
                {
                    hashCode = (hashCode * 59) + this.Sr.GetHashCode();
                }
                if (this.Sk != null)
                {
                    hashCode = (hashCode * 59) + this.Sk.GetHashCode();
                }
                if (this.Es != null)
                {
                    hashCode = (hashCode * 59) + this.Es.GetHashCode();
                }
                if (this.Sv != null)
                {
                    hashCode = (hashCode * 59) + this.Sv.GetHashCode();
                }
                if (this.Th != null)
                {
                    hashCode = (hashCode * 59) + this.Th.GetHashCode();
                }
                if (this.Tr != null)
                {
                    hashCode = (hashCode * 59) + this.Tr.GetHashCode();
                }
                if (this.Uk != null)
                {
                    hashCode = (hashCode * 59) + this.Uk.GetHashCode();
                }
                if (this.Vi != null)
                {
                    hashCode = (hashCode * 59) + this.Vi.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
