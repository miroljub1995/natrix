export class TestUnionProperties {
    value = 3;
    enumValue = "enum-value-2";

    callbackValue = (value) => {
        // Default implementation does nothing
    };

    set callCallbackValueOnSet(value) {
        this.callbackValue(value);
    }
}

globalThis.TestUnionProperties = TestUnionProperties;
