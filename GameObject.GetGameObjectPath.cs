/* via https://answers.unity.com/questions/8500/how-can-i-get-the-full-path-to-a-gameobject.html */
public static string GetGameObjectPath(GameObject obj)
{
    string path = "/" + obj.name;
    while (obj.transform.parent != null)
    {
        obj = obj.transform.parent.gameObject;
        path = "/" + obj.name + path;
    }
    return path;
}
