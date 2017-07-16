﻿using NBitcoin;

namespace NTumbleBit.Services
{
	public interface ITrustedBroadcastService
    {
		void Broadcast(int cycleStart, TransactionType transactionType, uint correlation, TrustedBroadcastRequest broadcast);
		TrustedBroadcastRequest GetKnownTransaction(uint256 txId);
		Transaction[] TryBroadcast(ref uint256[] knownBroadcasted);
		Transaction[] TryBroadcast();

	}
}
