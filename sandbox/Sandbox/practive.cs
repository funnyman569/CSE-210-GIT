using System.Runtime.InteropServices;

class denominationBin()
{
    private string _id;
    private int _centsValue;
    private int _count;

    public denominationBin(string idParam, int cvParam, int countParam)
    {
        _id = idParam;
        _centsValue = cvParam;
        _count = countParam;
    }

    //getters

    public string GetID() {return _id; }
    public int GetValueInCents() {return _centsValue; }
    public int GetCount() { return _count; }

    //setters
    public void SetID(string idParam ) {_id = idParam; }
    public void SetCentsValue(int cvParam) {_centsValue = cvParam;}
    public void SetCount(int countParam) {_count = countParam; }

}