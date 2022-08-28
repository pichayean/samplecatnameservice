using samplecatnameservice.Entities;

namespace samplecatnameservice.Data;
public class CatData
{
    private List<CatEntity> Cats;
    public List<CatEntity> Get()
    {
        return Cats;
    }

    public void Set(CatEntity entity)
    {
        if (Cats == null)
            Cats = new List<CatEntity>();
        Cats.Add(entity);
    }

    public void Remove(CatEntity entity)
    {
        if (Cats != null)
            Cats.Remove(entity);
    }
}