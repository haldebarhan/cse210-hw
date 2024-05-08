class Fraction {
    private int _top;
    private int _bottom;

    public Fraction(){
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top){
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom){
        _top = top;
        _bottom = bottom;
    }

    public int getTop(){
        return _top;
    }

    public int getBottom(){
        return _bottom;
    }

    public void setTop(int top){
        _top = top;
    }

    public void setBottom(int bottom){
        if (bottom != 0){
        _bottom = bottom;
        } else throw new ArgumentException("The denominator cannot be zero.");
    }

    public string GetFractionString(){
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue(){
        return  ( double)_top / _bottom;
    }
}