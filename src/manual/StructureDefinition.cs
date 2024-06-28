// Structure Definition
public struct CommonInfoDrawAndObtainParameters
{
    private ModelCloud2<IModel2> _model;
    private ModelCloud2<IModel2> _limitLines;
    private List<IModel2> _left;
    private List<IModel2> _right;

    public CommonInfoDrawAndObtainParameters(
        ModelCloud2<IModel2> model,
        ModelCloud2<IModel2> limitLines,
        List<IModel2> left,
        List<IModel2> right)
    {
        this._model = model;
        this._limitLines = limitLines;
        this._left = left;
        this._right = right;
    }
    // El operador => opera como un GET ya que si hicieramos = no tengo permisos de acceso
    // sin embargo, solo puedo recoger info. si quisiera asignar info debo poner getters y setters
    // como en la estructura siguiente a esta.
    public ModelCloud2<IModel2> Model => this._model;
    public ModelCloud2<IModel2> LimitLines => this._limitLines;
    public List<IModel2> Left => this._left;
    public List<IModel2> Right => this._right;
}

public struct MarkingParams
{
    private double _markingSpeedProposal;
    private double _jumpingSpeedProposal;
    private double _windowTime;
    private double _markingDistance;
    private double _markingTime;
    private double _jumpingDistance;
    private double _jumpingTime;

    public MarkingParams(double markingSpeedProposal, double jumpingSpeedProposal, double windowTime, double markingDistance, double markingTime, double jumpingDistance, double jumpingTime)
    {
        this._markingSpeedProposal = markingSpeedProposal;
        this._jumpingSpeedProposal = jumpingSpeedProposal;
        this._windowTime = windowTime;
        this._markingDistance = markingDistance;
        this._markingTime = markingTime;
        this._jumpingDistance = jumpingDistance;
        this._jumpingTime = jumpingTime;
    }

    public double MarkingSpeedProposal { 
	    get => this._markingSpeedProposal;
	    set => this._markingSpeedProposal = value;
    }
    public double JumpingSpeedProposal { 
        get => this._jumpingSpeedProposal;
        set => this._jumpingSpeedProposal = value;
    }
    public double WindowTime {
        get => this._windowTime;
        set => this._windowTime = value;
    }
    public double MarkingDistance { 
        get => this._markingDistance;
        set => this._markingDistance = value;
    }
    public double MarkingTime { 
        get => this._markingTime;
        set => this._markingTime = value;
    }
    public double JumpingDistance 
    { 
        get => this._jumpingDistance;
        set => this._jumpingDistance = value;
    }
    public double JumpingTime
    {
        get => this._jumpingTime;
        set => this._jumpingTime = value;
    }

    public override string ToString() => $"({MarkingSpeedProposal}, {JumpingSpeedProposal}, {WindowTime}, {MarkingDistance}, {MarkingTime}, {JumpingDistance}, {JumpingTime})";

    // The previous override is a simplification of the next one:
    public override string ToString()
    {
        return $"({MarkingSpeedProposal}, {JumpingSpeedProposal}, {WindowTime}, {MarkingDistance}, {MarkingTime}, {JumpingDistance}, {JumpingTime})";
    }
}