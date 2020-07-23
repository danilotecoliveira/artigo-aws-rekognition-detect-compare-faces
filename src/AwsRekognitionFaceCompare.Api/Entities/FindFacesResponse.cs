namespace AwsRekognitionFaceCompare.Api.Entities
{
    public class FindFacesResponse
    {
        public FindFacesResponse(string fileName)
        {
            DrawnImage = fileName;
        }

        public string DrawnImage { get; private set; }
    }
}
