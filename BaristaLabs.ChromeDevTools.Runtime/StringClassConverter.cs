namespace BaristaLabs.ChromeDevTools.Runtime
{
    using Newtonsoft.Json;
    using System;

    public class StringClassConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return true;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            try
            {
                if (reader.TokenType == JsonToken.String)
                {
                    string value = reader.Value.ToString();

                    return Activator.CreateInstance(objectType, value);
                }
            }
            catch (Exception ex)
            {
                throw new JsonSerializationException($"Error converting value {reader.Value} to type '{objectType}'.", ex);
            }

            // we don't actually expect to get here.
            throw new JsonSerializationException($"Unexpected token {reader.TokenType} when parsing sring class value.");
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(value.ToString());
        }
    }
}