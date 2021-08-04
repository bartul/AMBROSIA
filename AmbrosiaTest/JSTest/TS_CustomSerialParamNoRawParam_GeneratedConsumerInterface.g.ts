// Generated consumer-side API for the 'TS_CustomSerialParamNoRawParam_Generated' Ambrosia Node app/service.
// Publisher: (Not specified).
// Note: This file was generated
// Note [to publisher]: You can edit this file, but to avoid losing your changes be sure to specify a 'mergeType' other than 'None' (the default is 'Annotate') when re-running emitTypeScriptFile[FromSource]().
import Ambrosia = require("ambrosia-node");
import IC = Ambrosia.IC;
import Utils = Ambrosia.Utils;

const _knownDestinations: string[] = []; // All previously used destination instances (the 'TS_CustomSerialParamNoRawParam_Generated' Ambrosia app/service can be running on multiple instances, potentially simultaneously)
let _destinationInstanceName: string = ""; // The current destination instance
let _postTimeoutInMs: number = 8000; // -1 = Infinite

/** 
 * Sets the destination instance name that the API targets.\
 * Must be called at least once (with the name of a registered Ambrosia instance that implements the 'TS_CustomSerialParamNoRawParam_Generated' API) before any other method in the API is used.
 */
export function setDestinationInstance(instanceName: string): void
{
    _destinationInstanceName = instanceName.trim();
    if (_destinationInstanceName && (_knownDestinations.indexOf(_destinationInstanceName) === -1))
    {
        _knownDestinations.push(_destinationInstanceName);
    }
}

/** Returns the destination instance name that the API currently targets. */
export function getDestinationInstance(): string
{
    return (_destinationInstanceName);
}

/** Throws if _destinationInstanceName has not been set. */
function checkDestinationSet(): void
{
    if (!_destinationInstanceName)
    {
        throw new Error("setDestinationInstance() must be called to specify the target destination before the 'TS_CustomSerialParamNoRawParam_Generated' API can be used.");
    }
}

/**
 * Sets the post method timeout interval (in milliseconds), which is how long to wait for a post result from the destination instance before raising an error.\
 * All post methods will use this timeout value. Specify -1 for no timeout. 
 */
export function setPostTimeoutInMs(timeoutInMs: number): void
{
    _postTimeoutInMs = Math.max(-1, timeoutInMs);
}

/**
 * Returns the post method timeout interval (in milliseconds), which is how long to wait for a post result from the destination instance before raising an error.\
 * A value of -1 means there is no timeout.
 */
export function getPostTimeoutInMs(): number
{
    return (_postTimeoutInMs);
}

/**
Test when missing @param rawParams
 */
export namespace Test
{
    /**
     * Method to test custom serialized parameters.
     * @param rawParams A custom serialization (byte array) of all required parameters. Contact the 'TS_CustomSerialParamNoRawParam_Generated' API publisher for details of the serialization format.
     */
    export function takesCustomSerializedParams_Fork(rawParams: Uint8Array): void
    {
        checkDestinationSet();
        IC.callFork(_destinationInstanceName, 2, rawParams);
    }

    /**
     * Method to test custom serialized parameters.
     * @param rawParams A custom serialization (byte array) of all required parameters. Contact the 'TS_CustomSerialParamNoRawParam_Generated' API publisher for details of the serialization format.
     */
    export function takesCustomSerializedParams_Impulse(rawParams: Uint8Array): void
    {
        checkDestinationSet();
        IC.callImpulse(_destinationInstanceName, 2, rawParams);
    }

    /**
     * Method to test custom serialized parameters.
     * @param rawParams A custom serialization (byte array) of all required parameters. Contact the 'TS_CustomSerialParamNoRawParam_Generated' API publisher for details of the serialization format.
     */
    export function takesCustomSerializedParams_EnqueueFork(rawParams: Uint8Array): void
    {
        checkDestinationSet();
        IC.queueFork(_destinationInstanceName, 2, rawParams);
    }

    /**
     * Method to test custom serialized parameters.
     * @param rawParams A custom serialization (byte array) of all required parameters. Contact the 'TS_CustomSerialParamNoRawParam_Generated' API publisher for details of the serialization format.
     */
    export function takesCustomSerializedParams_EnqueueImpulse(rawParams: Uint8Array): void
    {
        checkDestinationSet();
        IC.queueImpulse(_destinationInstanceName, 2, rawParams);
    }
}