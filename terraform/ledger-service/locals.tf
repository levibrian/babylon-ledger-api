locals {
  ledger_resource_base_name  = "${var.client}-${local.environment}-investments"
  ledger_api_gateway_name    = "${local.ledger_resource_base_name}-api"
  ledger_lambda_name         = "${local.ledger_resource_base_name}-lambda"
  entry_dynamodb_table_name = "${local.ledger_resource_base_name}-entry-table"
  ledger_lambda_file_path    = "${var.packages_path}/${var.package_file_name}"
  ledger_subdomain_name      = "${local.ledger_resource_base_name}-api-subdomain-name"
  environment                      = var.env_suffix == "" ? substr(terraform.workspace, 0, 3) : var.env_suffix
  logs_retention_in_days           = 14
  default_tags = {
    Stage        = local.environment
    Client       = var.client
    Service      = var.service_name
    ServiceGroup = local.ledger_resource_base_name
    Version      = var.version_tag
  }
}