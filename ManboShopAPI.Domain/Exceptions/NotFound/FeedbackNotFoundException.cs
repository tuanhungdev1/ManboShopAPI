using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Domain.Exceptions.NotFound
{
	public sealed class FeedbackNotFoundException : NotFoundException
	{
		public FeedbackNotFoundException(int feedbackId) : base($"Feedback with id {feedbackId} not found.")
		{
		}

		public FeedbackNotFoundException(string message) : base(message)
		{
		}
	}
}
