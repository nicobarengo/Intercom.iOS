using ObjCRuntime;

namespace BarengoEngineering.Intercom
{
    [Native]
    public enum ContentType : long
    {
        article,
        survey,
        carousel,
        helpCenterCollections,
        conversation
    }

    [Native]
    public enum Space : long
    {
        home,
        helpCenter,
        messages,
        tickets
    }
}