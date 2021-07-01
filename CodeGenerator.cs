using NJsonSchema;
using NJsonSchema.CodeGeneration.CSharp;

namespace Glowing
{
    interface ICodeGenerator
    {
        string GenerateCode(string json);
    }

    class JsonGenerator : ICodeGenerator
    {
        public string GenerateCode(string json)
        {
            var schemaFromFile = JsonSchema.FromSampleJson(json);
            var classGenerator = new CSharpGenerator(schemaFromFile, new CSharpGeneratorSettings
            {
                ClassStyle = CSharpClassStyle.Poco,
            });
            return classGenerator.GenerateFile();
        }
    }
}
