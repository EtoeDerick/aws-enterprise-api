

variable "aws_region" {
  type        = string
  default     = "us-east-1"
  description = "aws_region - description"
}

variable "project_name" {
  type        = string
  default     = "aws-enterprise-api"
  description = "project_name - description"
}

variable "environment" {
  type        = string
  default     = "dev"
  description = "environment - description"
}
