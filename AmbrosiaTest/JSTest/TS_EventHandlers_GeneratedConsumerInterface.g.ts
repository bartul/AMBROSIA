// Generated consumer-side API for the 'TS_EventHandlers_Generated' Ambrosia Node app/service.
// Publisher: (Not specified).
// Note: This file was generated
// Note [to publisher]: You can edit this file, but to avoid losing your changes be sure to specify a 'mergeType' other than 'None' (the default is 'Annotate') when re-running emitTypeScriptFile[FromSource]().
import Ambrosia = require("ambrosia-node");
import IC = Ambrosia.IC;
import Utils = Ambrosia.Utils;

const _knownDestinations: string[] = []; // All previously used destination instances (the 'TS_EventHandlers_Generated' Ambrosia app/service can be running on multiple instances, potentially simultaneously)
let _destinationInstanceName: string = ""; // The current destination instance
let _postTimeoutInMs: number = 8000; // -1 = Infinite

/** 
 * Sets the destination instance name that the API targets.\
 * Must be called at least once (with the name of a registered Ambrosia instance that implements the 'TS_EventHandlers_Generated' API) before any other method in the API is used.
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
        throw new Error("setDestinationInstance() must be called to specify the target destination before the 'TS_EventHandlers_Generated' API can be used.");
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

export namespace Test
{
    /**
     * *Note: The result (void) produced by this post method is received via the PostResultDispatcher provided to IC.start(). Returns the post method callID.*
     * 
     * Fake Event Handler due to case in the name so this will be generated
     */
    export function onbecomingprimary_Post(callContextData: any): number
    {
        checkDestinationSet();
        const callID = IC.postFork(_destinationInstanceName, "onbecomingprimary", 1, _postTimeoutInMs, callContextData);
        return (callID);
    }

    /**
     * *Note: The result (void) produced by this post method is received via the PostResultDispatcher provided to IC.start().*
     * 
     * Fake Event Handler due to case in the name so this will be generated
     */
    export function onbecomingprimary_PostByImpulse(callContextData: any): void
    {
        checkDestinationSet();
        IC.postByImpulse(_destinationInstanceName, "onbecomingprimary", 1, _postTimeoutInMs, callContextData);
    }
}

/**
 * Handler for the results of previously called post methods (in Ambrosia, only 'post' methods return values). See Messages.PostResultDispatcher.\
 * Must return true only if the result (or error) was handled.
 */
export function postResultDispatcher(senderInstanceName: string, methodName: string, methodVersion: number, callID: number, callContextData: any, result: any, errorMsg: string): boolean
{
    const sender: string = IC.isSelf(senderInstanceName) ? "local" : `'${senderInstanceName}'`;
    let handled: boolean = true;

    if (_knownDestinations.indexOf(senderInstanceName) === -1)
    {
        return (false); // Not handled: this post result is from a different instance than the destination instance currently (or previously) targeted by the 'TS_EventHandlers_Generated' API
    }

    if (errorMsg)
    {
        switch (methodName)
        {
            case "onbecomingprimary":
                Utils.log(`Error: ${errorMsg}`);
                break;
            default:
                handled = false;
                break;
        }
    }
    else
    {
        switch (methodName)
        {
            case "onbecomingprimary":
                // TODO: Handle the method completion (it returns void), optionally using the callContextData passed in the call
                Utils.log(`Post method '${methodName}' from ${sender} IC succeeded`);
                break;
            default:
                handled = false;
                break;
        }
    }
    return (handled);
}