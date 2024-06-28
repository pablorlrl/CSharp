// Constructor with inheritance definition.
public Pcie(string ip, Module2Params module2Params, int numberOfPets) : base(ip, module2Params)
{
    this._petsCount = numberOfPets;
    this._correctionSettings = new CorrectionSettings(module2Params.CorrectionFile);
}