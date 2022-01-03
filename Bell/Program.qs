namespace Bell {
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Canon;

    @EntryPoint()
    operation entry() : Result {
        use q1 = Qubit();
        return SetQubitState(One, q1);
    }

    // This operation sets the value of the qubit to whatever the value of "desired" is.
    // PARAMS: Desired measured quantum state "desired" and input qubit "target"
    // RETURNS: Result of qubit measurement, either 0 or 1.
    operation SetQubitState(desired : Result, target : Qubit) : Result {
        if desired != M(target) {
            X(target);
        }
        return M(target);
    }
}